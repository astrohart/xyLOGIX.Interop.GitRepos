namespace xyLOGIX.Interop.LibGit2Sharp.Events
{
    /// <summary>
    /// Delegate for a PullFailed event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Events.PullFailedEventArgs" /> that
    /// contains the event data.
    /// </param>
    public delegate void PullFailedEventHandler(object sender,
        PullFailedEventArgs e);
}