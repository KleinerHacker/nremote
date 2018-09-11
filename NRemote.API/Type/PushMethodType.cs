namespace NRemote.API.Type
{
    /// <summary>
    /// Type of push method
    /// </summary>
    public enum PushMethodType
    {
        /// <summary>
        /// A default field is pushed / updated (contains complete list and array updates)
        /// </summary>
        Default,
        /// <summary>
        /// A single item of a list / array is pushed / updated, see {@link PushItemUpdate}
        /// </summary>
        SingleListItem
    }
}