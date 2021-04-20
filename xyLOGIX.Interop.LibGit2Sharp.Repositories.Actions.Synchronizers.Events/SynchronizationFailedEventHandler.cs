namespace xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Synchronizers.Events
{
    /// <summary>
    /// Delegate for a SynchronizationFailed event.
    /// </summary>
    /// <param name="sender">Reference to the instance of the object that raised the event.</param>
    /// <param name="e">A <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Synchronizers.Events.SynchronizationFailedEventArgs" /> that contains the event data.</param>
    public delegate void SynchronizationFailedEventHandler(object sender, SynchronizationFailedEventArgs e);
}