namespace Caelan.Frameworks.DAL.Interfaces
    type IEntity = interface end

    type IEntity<'TKey when 'TKey :> System.IEquatable<'TKey>> =
        inherit IEntity
        abstract member ID : 'TKey with get, set