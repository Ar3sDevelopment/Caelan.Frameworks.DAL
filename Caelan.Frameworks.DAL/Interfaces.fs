namespace Caelan.Frameworks.DAL.Interfaces
    type IEntity = interface end

    type IEntity<'TKey when 'TKey :> System.IEquatable<'TKey>> =
        inherit IEntity
        abstract member ID : 'TKey with get, set

    type ISet<'TEntity when 'TEntity :> IEntity> =
        inherit System.Linq.IQueryable<'TEntity>
        abstract member Insert : 'TEntity -> bool
        abstract member Update : 'TEntity -> bool
        abstract member Delete : 'TEntity -> bool

    type IContext =
        abstract member Save : unit -> int