using System;

namespace Caelan.Frameworks.DAL.Interfaces
{
	public interface ISet
	{
		bool Insert(IEntity entity);
		bool Update(IEntity entity);
		bool Delete(IEntity entity);
	}

	public interface ISet<in TKey> where TKey : IEquatable<TKey>
	{
		bool Insert(IEntity<TKey> entity);
		bool Update(IEntity<TKey> entity);
		bool Delete(IEntity<TKey> entity);
	}

	public interface ISet<in TEntity, TKey>
		where TEntity : IEntity<TKey>
		where TKey : IEquatable<TKey>
	{
		bool Insert(TEntity entity);
		bool Update(TEntity entity);
		bool Delete(TEntity entity);
	}
}
