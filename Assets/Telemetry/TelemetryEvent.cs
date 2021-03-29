using UnityEngine;
using System;

[Serializable]
public struct TelemetryEvent
{
    public uint session;
    public string level;
    public string eventType;

    public long timecode;
    public DateTimeOffset time {
        get {
            return DateTimeOffset.FromUnixTimeMilliseconds(timecode);
        }
        set {
            timecode = value.ToUnixTimeMilliseconds();
        }
    }

    public string fromAttribute;
    public Vector3 fromPosition;

    public string toAttribute;
    public Vector3 toPosition;   

    public float numberAttribute;

    public override string ToString() {
        return $"[{session} {level} {eventType} {time.LocalDateTime} {fromAttribute} {fromPosition} {toAttribute} {toPosition} {numberAttribute}]";
    }
}