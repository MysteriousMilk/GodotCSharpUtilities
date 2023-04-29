﻿namespace Godot.Common.Extensions;

public static class AnimationPlayerExtensions
{
    //
    // Summary:
    //     Plays the animation with key [param name]. Custom blend times and speed can be
    //     set. If [param custom_speed] is negative and [param from_end] is true, the animation
    //     will play backwards (which is equivalent to calling Godot.AnimationPlayer.PlayBackwards(Godot.StringName,System.Double)).
    //     The Godot.AnimationPlayer keeps track of its current or last played animation
    //     with Godot.AnimationPlayer.AssignedAnimation. If this method is called with that
    //     same animation [param name], or with no [param name] parameter, the assigned
    //     animation will resume playing if it was paused, or restart if it was stopped
    //     (see Godot.AnimationPlayer.Stop(System.Boolean) for both pause and stop). If
    //     the animation was already playing, it will keep playing.
    //     Note: The animation will be updated the next time the Godot.AnimationPlayer is
    //     processed. If other variables are updated at the same time this is called, they
    //     may be updated too early. To perform the update immediately, call advance(0).
    public static void PlayDeferred(this AnimationPlayer animationPlayer, StringName name = null, double customBlend = -1.0, float customSpeed = 1f, bool fromEnd = false)
    {
        animationPlayer.CallDeferred(AnimationPlayer.MethodName.Play, name, customBlend, customSpeed, fromEnd);
    }
}
