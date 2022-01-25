using System.Collections.Generic;

namespace _0.LMS.Domain.SeedWork
{
    public abstract class BaseEntity<TKey>
    {
        public TKey Id { get; set; }

        private readonly List<IDomainEvent> _domainEvents = new List<IDomainEvent>();
        public IReadOnlyCollection<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();
        private readonly List<string> _errorMessage = new List<string>();
        public IReadOnlyCollection<string> ErrorMessage => _errorMessage.AsReadOnly();

        protected void AddDomainEvent(IDomainEvent eventItem)
        {
            _domainEvents.Add(eventItem);
        }

        protected void RemoveDomainEvent(IDomainEvent eventItem)
        {
            _domainEvents?.Remove(eventItem);
        }

        public void ClearDomainEvents()
        {
            _domainEvents?.Clear();
        }

        protected void AddDErrorMessage(string error)
        {
            _errorMessage.Add(error);
        }

        protected void RemoveErrorMessage(string error)
        {
            _errorMessage?.Remove(error);
        }

        public void ClearErrorMessage()
        {
            _errorMessage?.Clear();
        }
    }
}