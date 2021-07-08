using System;

namespace Core.Model
{
    public interface IEntity
    {

    }

    public class Entity : IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}