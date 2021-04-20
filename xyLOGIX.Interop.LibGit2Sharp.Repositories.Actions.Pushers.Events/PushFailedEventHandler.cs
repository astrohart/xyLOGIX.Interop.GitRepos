namespace xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Pushers.Events
{
    /// <summary>
    /// Delegate for a PushFailed event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Pushers.Events.PushFailedEventArgs" /> that
    /// contains the event data.
    /// </param>
    public delegate void PushFailedEventHandler(object sender,
        PushFailedEventArgs e);
}