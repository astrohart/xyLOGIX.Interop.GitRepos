namespace xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Stagers.Events
{
    /// <summary>
    /// Delegate for a StageFailed event.
    /// </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:xyLOGIX.Interop.LibGit2Sharp.Repositories.Actions.Stagers.Events.StageFailedEventArgs" /> that contains
    /// the event data.
    /// </param>
    public delegate void StageFailedEventHandler(object sender,
        StageFailedEventArgs e);
}