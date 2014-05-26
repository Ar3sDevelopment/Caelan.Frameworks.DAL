using System;

namespace Caelan.Frameworks.DAL.Interfaces
{
	public interface IEntity
	{
	}

	public interface IEntity<out T> : IEntity where T : IEquatable<T>
	{
		T ID { get; }
	}
}
