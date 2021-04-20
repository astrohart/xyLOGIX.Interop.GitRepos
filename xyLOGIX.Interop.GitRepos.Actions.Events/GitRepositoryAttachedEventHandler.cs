namespace xyLOGIX.Interop.GitRepos.Actions.Events
{
    /// <summary>
    /// Delegate for a GitRepositoryAttached event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:xyLOGIX.Interop.GitRepos.Actions.Events.GitRepositoryAttachedEventArgs" /> that
    /// contains the event data.
    /// </param>
    public delegate void GitRepositoryAttachedEventHandler(object sender,
        GitRepositoryAttachedEventArgs e);
}