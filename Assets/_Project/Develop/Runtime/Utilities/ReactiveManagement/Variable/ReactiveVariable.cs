using System;
using System.Collections.Generic;

namespace _Project.Develop.Runtime.Utils.ReactiveManagement
{
    public class ReactiveVariable<T> : IReadOnlyVariable<T>
    {
        private readonly List<Subscriber<T, T>> _subscribers = new ();
        private readonly List<Subscriber<T, T>> _toAddList = new ();
        private readonly List<Subscriber<T, T>> _toRemoveList = new ();

        private T _value;
        private IEqualityComparer<T> _comparer;

        public ReactiveVariable() : this(default) { }

        public ReactiveVariable(T value) : this(value, EqualityComparer<T>.Default){ }

        public ReactiveVariable(T value, IEqualityComparer<T> comparer)
        {
            _value = value;
            _comparer = comparer;
        }
        
        public T Value
        {
            get => _value;
            set
            {
                T oldValue = _value;
                _value = value;

                if (_comparer.Equals(oldValue, value) == false)
                    Invoke(oldValue, _value);
            }
        }

        public IDisposable Subscribe(Action<T, T> action)
        {
            Subscriber<T, T> subscriber = new (action, RemoveSubscriber);
            _toAddList.Add(subscriber);

            return subscriber;
        }

        private void RemoveSubscriber(Subscriber<T, T> subscriber) => _toRemoveList.Add(subscriber);

        private void Invoke(T oldValue, T newValue)
        {
            if (_toAddList.Count > 0)
            {
                _subscribers.AddRange(_toAddList);
                _toAddList.Clear();
            }

            if (_toRemoveList.Count > 0)
            {
                foreach (Subscriber<T, T> subscriber in _toRemoveList)
                    _subscribers.Remove(subscriber);

                _toRemoveList.Clear();
            }

            foreach (Subscriber<T, T> subscriber in _subscribers)
                subscriber.Invoke(oldValue, newValue);
        }
    }
}
