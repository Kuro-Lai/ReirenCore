using UnityEngine;

namespace ReirenCore
{
    using Enums;
    using ExtensionMethods;
    using UnityEditor.Experimental.GraphView;

    /// <summary>
    /// Ein Vector, welcher zum Abspeichern mittels JSON verwendet werden kann.
    /// </summary>
    [System.Serializable]
    public class VectorSaveable
    {
        public float X { get; set; } = 0;
        public float Y { get; set; } = 0;
        public float Z { get; set; } = 0;

        /// <summary>
        /// Erstellt aus einem UnityVector in eine Abspeicherbare Klasse
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public VectorSaveable (Vector2 vector)
        {
            X = vector.x;
            Y = vector.y;
            Z = 0;
        }
        /// <summary>
        /// Erstellt aus einem UnityVector in eine Abspeicherbare Klasse
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public VectorSaveable (Vector3 vector)
        {
            X = vector.x;
            Y = vector.y;
            Z = vector.z;
        }
        /// <summary>
        /// Gibt den VectorSaveable als 2D Richtung zurück
        /// </summary>
        /// <param name="_3D">Wenn true wird die Z achse anstelle > verwendet</param>
        /// <param name="Axis9">Wenn True wird der Vector auf 9 Achsen ausgegeben</param>
        /// <returns>North, South, East, West</returns>
        public Facing2D ToFacing2D(bool _3D = false, bool Axis9 = false)
        {
            if(Axis9)
            {
                Vector3 vector3 = this.ToVector3();
                float angle;
                if (_3D)
                {
                    angle = Vector3.SignedAngle(Vector3.forward, vector3, Vector3.up);
                }
                else
                {
                    angle = Vector3.SignedAngle(Vector3.forward, vector3, Vector3.forward);
                }
                angle = (angle < 0 ? angle + 360 : angle) - 45 / 2;
                switch (angle.StepRound(45))
                {
                    case 0:
                        return Facing2D.North;
                    case 45:
                        return Facing2D.North | Facing2D.East;
                    case 90:
                        return Facing2D.East;
                    case 135:
                        return Facing2D.South | Facing2D.East;
                    case 180:
                        return Facing2D.South;
                    case 225:
                        return Facing2D.South | Facing2D.West;
                    case 270:
                        return Facing2D.West;
                    case 315:
                        return Facing2D.West | Facing2D.North;
                    default:
                        return Facing2D.North;
                }
            }
            else
            {
                return this.ToVector3().ToFacing2D(_3D);
            }

        }
        /// <summary>
        /// Gibt den VectorSaveable als Unity Vector2 zurück
        /// </summary>
        /// <returns></returns>
        public Vector2 ToVector2()
        {
            return new Vector2() { x = (float)X, y = (float)Y };
        }
        /// <summary>
        /// Gibt den VectorSaveable als Unity Vector2 zurück
        /// </summary>
        /// <returns></returns>
        public Vector3 ToVector3()
        {
            return new Vector3() { x = (float)X, y = (float)Y, z = (float)Z };
        }
    }
}