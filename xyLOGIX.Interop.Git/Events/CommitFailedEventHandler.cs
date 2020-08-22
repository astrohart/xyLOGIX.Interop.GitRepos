namespace xyLOGIX.Interop.Git.Events
{
    /// <summary>
    /// Delegate for a CommitFailed event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:xyLOGIX.Interop.Git.Events.CommitFailedEventArgs" /> that
    /// contains the event data.
    /// </param>
    public delegate void CommitFailedEventHandler(object sender,
        CommitFailedEventArgs e);
}