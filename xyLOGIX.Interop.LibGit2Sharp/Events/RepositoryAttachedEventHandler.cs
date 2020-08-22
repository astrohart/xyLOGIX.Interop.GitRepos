namespace xyLOGIX.Interop.LibGit2Sharp.Events
{
    /// <summary>
    /// Delegate for a RepositoryAttached event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Events.RepositoryAttachedEventArgs" /> that
    /// contains the event data.
    /// </param>
    public delegate void RepositoryAttachedEventHandler(object sender,
        RepositoryAttachedEventArgs e);
}