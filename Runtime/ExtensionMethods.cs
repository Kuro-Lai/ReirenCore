using System.ComponentModel;
using System.Text;
using System;
using UnityEngine;

namespace ReirenCore.ExtensionMethods
{
    using Enums;

    public static class Extensions
    {

        #region Rundungsfunktionen
        /// <summary>
        /// Rundet eine Zahl auf eine definierte Schrittweite.
        /// </summary>
        /// <param name="val">Wert welcher gerundet werden soll.</param>
        /// <param name="Stepsize">Schrittweite auf welche die Ausgabe gerundet wird.</param>
        /// <returns>Gibt eine Zahl gerundet auf die Schrittweite zurück</returns>
        public static float Round(float val, float Stepsize = 0.5f)
        {
            return Mathf.Round(val * (1 / Stepsize)) / (1 / Stepsize);
        }
        /// <summary>
        /// Rundet eine Zahl auf eine definierte Schrittweite.
        /// </summary>
        /// <param name="val">Wert welcher gerundet werden soll.</param>
        /// <param name="Stepsize">Schrittweite auf welche die Ausgabe gerundet wird.</param>
        /// <returns>Gibt eine Zahl gerundet auf die Schrittweite zurück</returns>
        public static float StepRound(this float val, float Stepsize = 0.5f)
        {
            return Mathf.Round(val * (1 / Stepsize)) / (1 / Stepsize);
        }

        /// <summary>
        /// Rundet einen Vector2 auf eine definierte Schrittweite.
        /// </summary>
        /// <param name="val">Wert welcher gerundet werden soll.</param>
        /// <param name="Stepsize">Schrittweite auf welche die Ausgabe gerundet wird.</param>
        /// <returns>Gibt einen Vector gerundet auf die Schrittweite zurück</returns>
        public static Vector2 Round2(Vector2 val, float Stepsize = 0.5f)
        {
            return new Vector2() { x = Mathf.Round(val.x * (1 / Stepsize)) / (1 / Stepsize), y = Mathf.Round(val.y * (1 / Stepsize)) / (1 / Stepsize) };
        }
        /// <summary>
        /// Rundet einen Vector2 auf eine definierte Schrittweite.
        /// </summary>
        /// <param name="val">Wert welcher gerundet werden soll.</param>
        /// <param name="Stepsize">Schrittweite auf welche die Ausgabe gerundet wird.</param>
        /// <returns>Gibt einen Vector gerundet auf die Schrittweite zurück</returns>
        public static Vector2 StepRound2(this Vector2 val, float Stepsize = 0.5f)
        {
            return new Vector2() { x = Mathf.Round(val.x * (1 / Stepsize)) / (1 / Stepsize), y = Mathf.Round(val.y * (1 / Stepsize)) / (1 / Stepsize) };
        }

        /// <summary>
        /// Rundet einen Vector3 auf eine definierte Schrittweite.
        /// </summary>
        /// <param name="val">Wert welcher gerundet werden soll.</param>
        /// <param name="Stepsize">Schrittweite auf welche die Ausgabe gerundet wird.</param>
        /// <returns>Gibt einen Vector gerundet auf die Schrittweite zurück</returns>
        public static Vector3 Round3(Vector3 val, float Stepsize = 0.5f)
        {
            return new Vector3() { x = Mathf.Round(val.x * (1 / Stepsize)) / (1 / Stepsize),
                y = Mathf.Round(val.y * (1 / Stepsize)) / (1 / Stepsize),
                z = Mathf.Round(val.z * (1 / Stepsize)) / (1 / Stepsize)
            };
        }
        /// <summary>
        /// Rundet einen Vector2 auf eine definierte Schrittweite.
        /// </summary>
        /// <param name="val">Wert welcher gerundet werden soll.</param>
        /// <param name="Stepsize">Schrittweite auf welche die Ausgabe gerundet wird.</param>
        /// <returns>Gibt einen Vector gerundet auf die Schrittweite zurück</returns>
        public static Vector3 StepRound3(this Vector3 val, float Stepsize = 0.5f)
        {
            return new Vector3() { x = Mathf.Round(val.x * (1 / Stepsize)) / (1 / Stepsize),
                y = Mathf.Round(val.y * (1 / Stepsize)) / (1 / Stepsize),
                z = Mathf.Round(val.z * (1 / Stepsize)) / (1 / Stepsize)
            };
        }
        #endregion

        #region JSON XML Speicherfunktionshelfer

        /// <summary>
        /// Gibt einen Abspeicherbaren Vector für z.B. JSON zurück
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static VectorSaveable Safe(this Vector2 vector)
        {
            return new VectorSaveable(vector);
        }
        /// <summary>
        /// Gibt einen Abspeicherbaren Vector für z.B. JSON zurück
        /// </summary>
        /// <param name="vector"></param>
        /// <returns></returns>
        public static VectorSaveable Safe(this Vector3 vector)
        {
            return new VectorSaveable(vector);
        }

        /// <summary>
        /// Gibt einen Abspeicherbaren Vector für z.B. JSON zurück
        /// Konvertiert auch eine 9 Axen Richtungsangabe
        /// </summary>
        /// <param name="facing">North, South, East, West</param>
        /// <param name="faktor">Längenscallierung des Vectors</param>
        /// <returns></returns>
        public static VectorSaveable Safe(this Facing2D facing, float faktor = 1.0f, bool _3D = false)
        {
            if(_3D)
            {
                return facing switch
                {
                    Facing2D.North => (Vector3.forward * faktor).Safe(),
                    Facing2D.West => (Vector3.left * faktor).Safe(),
                    Facing2D.East => (Vector3.right * faktor).Safe(),
                    Facing2D.South => (Vector3.back * faktor).Safe(),
                    Facing2D.North | Facing2D.West => ((Vector3.forward + Vector3.left).normalized * faktor).Safe(),
                    Facing2D.North | Facing2D.East => ((Vector3.forward + Vector3.right).normalized * faktor).Safe(),
                    Facing2D.South | Facing2D.West => ((Vector3.back + Vector3.left).normalized * faktor).Safe(),
                    Facing2D.South | Facing2D.East => ((Vector3.back + Vector3.right).normalized * faktor).Safe(),
                    _ => (Vector3.zero).Safe(),
                };
            }
            else
            {
                return facing switch
                {           
                    Facing2D.North => (Vector2.up * faktor).Safe(),
                    Facing2D.West => (Vector2.left * faktor).Safe(),
                    Facing2D.East => (Vector2.right * faktor).Safe(),
                    Facing2D.South => (Vector2.down * faktor).Safe(),
                    Facing2D.North | Facing2D.West => ((Vector2.up + Vector2.left).normalized * faktor).Safe(),
                    Facing2D.North | Facing2D.East => ((Vector2.up + Vector2.right).normalized * faktor).Safe(),
                    Facing2D.South | Facing2D.West => ((Vector2.down + Vector2.left).normalized * faktor).Safe(),
                    Facing2D.South | Facing2D.East => ((Vector2.down + Vector2.right).normalized * faktor).Safe(),
                    _ => (Vector2.zero).Safe(),
                };
            }

        }

        #endregion

        #region 2D Ausrichtungshelper

        /// <summary>
        /// Konvertiert einen Vector2 in einen 2D Facing Parameter.
        /// Gibt bei VectorZero immer South zurück.
        /// </summary>
        /// <param name="vector"></param>
        /// <returns>North, South, East, West</returns>
        public static Facing2D ToFacing2D(this Vector2 vector)
        {
            if (vector.x > 0 && vector.x > Mathf.Abs(vector.y))
                return Facing2D.East;
            else if (vector.x < 0 && -vector.x > Mathf.Abs(vector.y))
                return Facing2D.West;
            else if (vector.y > 0)
                return Facing2D.North;
            else
                return Facing2D.South;
        }
        /// <summary>
        /// Konvertiert einen Vector3 in einen 2D Facing Parameter.
        /// Gibt bei VectorZero immer South zurück
        /// </summary>
        /// <param name="vector"></param>
        /// <param name="_3D">Wenn true, wird die z-Achse anstelle der y-Achse verwendet</param>
        /// <returns>North, South, East, West</returns>
        public static Facing2D ToFacing2D(this Vector3 vector, bool _3D = false)
        {
            if (_3D)
            {
                if (vector.x > 0 && vector.x > Mathf.Abs(vector.z))
                    return Facing2D.East;
                else if (vector.x < 0 && -vector.x > Mathf.Abs(vector.z))
                    return Facing2D.West;
                else if (vector.z > 0)
                    return Facing2D.North;
                else
                    return Facing2D.South;
            }
            else
            {
                if (vector.x > 0 && vector.x > Mathf.Abs(vector.y))
                    return Facing2D.East;
                else if (vector.x < 0 && -vector.x > Mathf.Abs(vector.y))
                    return Facing2D.West;
                else if (vector.y > 0)
                    return Facing2D.North;
                else
                    return Facing2D.South;
            }
        }
        /// <summary>
        /// Konvertiert eine 2D Facingangabe in einen Vector.
        /// Falls als Mask übergeben wird VectorZero Zurückgegeben
        /// </summary>
        /// <param name="facing"></param>
        /// <param name="_3D">Wenn true gibt es die Richtung South mit Back, ansonsten mit Down zurück</param>
        /// <param name="faktor">Skallierung für den Vector</param>
        /// <returns></returns>
        public static Vector3 ToVector3(this Facing2D facing, bool _3D = false, float faktor = 1.0f)
        {
            if(_3D)
            {
                return facing switch
                {
                    Facing2D.North => Vector3.forward * faktor,
                    Facing2D.West => Vector3.left * faktor,
                    Facing2D.East => Vector3.right * faktor,
                    Facing2D.South => Vector3.back * faktor,
                    _ => Vector3.zero,
                };
            }
            else
            {
                return facing switch
                {
                    Facing2D.North => Vector3.up * faktor,
                    Facing2D.West => Vector3.left * faktor,
                    Facing2D.East => Vector3.right * faktor,
                    Facing2D.South => Vector3.down * faktor,
                    _ => Vector3.zero,
                };
            }

        }
        /// <summary>
        /// Konvertiert eine 2D Facingangabe in einen Vector.
        /// Falls als Mask übergeben wird VectorZero Zurückgegeben
        /// </summary>
        /// <param name="facing"></param>
        /// <param name="faktor">Skallierung für den Vector</param>
        /// <returns></returns>
        public static Vector2 ToVector2(this Facing2D facing, float faktor = 1.0f)
        {
            return facing switch
            {
                Facing2D.North => Vector2.up * faktor,
                Facing2D.West => Vector2.left * faktor,
                Facing2D.East => Vector2.right * faktor,
                Facing2D.South => Vector2.down * faktor,
                _ => Vector2.zero,
            };
        }
        
        #endregion


        /// <summary>
        /// Konvertiert ein Texture in ein Srite
        /// </summary>
        /// <param name="texture2D"></param>
        /// <returns></returns>
        public static Sprite ToSprite(this Texture2D texture2D, Vector2? pivot = null)
        {
            if (texture2D == null) return null;
            return Sprite.Create(texture2D, 
                new Rect(0, 0, texture2D.width, texture2D.height), 
                pivot != null ? pivot.Value : new Vector2(0.5f, 0.5f)
                );
        }


        /// <summary>
        /// Gibt einen Beschreibungstext eines Enum zurück wenn dieser wie folgt definiert wurde:
        /// 
        /// </summary>
        /// <param name="enumValue"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static string GetEnumDescription(this Enum enumValue)
        {
            var field = enumValue.GetType().GetField(enumValue.ToString());
            if (Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) is DescriptionAttribute attribute)
            {
                return attribute.Description;
            }
            throw new ArgumentException("Item not found.", nameof(enumValue));
        }



        /// <summary>
        /// Gibt von einer unbekannten Deklaration des typs object über den Propertynamen den Wert zurück, sofern dieser vorhanden ist.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propertyName"></param>
        /// <returns></returns>
        public static object GetPropertyValue(this object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName)?.GetValue(obj, null);
        }
        /// <summary>
        /// Setzt von einer unbekannten Deklaration des typs object über den Propertynamen den Wert, sofern dieser vorhanden ist.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="propName"></param>
        /// <param name="value"></param>
        public static void SetPropertyValue(this object obj, string propName, object value)
        {
            obj.GetType().GetProperty(propName)?.SetValue(obj, value, null);
        }


        /// <summary>
        /// Fügt Argumente in einen String mit Argumentnenplatzhalter ein.
        /// "test {0} {1} {3} repeat {0}" List {"a", "b"}
        /// "test a b {missing arg} repeat a"
        /// </summary>
        /// <param name="text">Text mit Platzhalterargumenten</param>
        /// <param name="args">Argumente zum ausfüllen</param>
        /// <returns></returns>
        public static string SmartArgs(this string text, params string[] args)
        {
            StringBuilder result = new StringBuilder();
            string ArgIndex = "";
            int index = 0;
            bool opened = false;

            foreach (var c in text)
            {
                if (c == '{')
                {
                    opened = true;
                    index = result.Length;
                }
                else if (opened && c == '}')
                {
                    opened = false;
                    int lenToRem = result.Length - index;

                    if (int.TryParse(ArgIndex, out int v))
                    {
                        ArgIndex = "";
                        string p = args.Length > v ? args[v] : "{missing arg}";
                        result.Append(p);
                    }
                    result.Remove(index, lenToRem);

                    continue;
                }
                else if (opened && !Char.IsDigit(c))
                {
                    opened = false;
                    ArgIndex = "";
                }
                else if (opened && Char.IsDigit(c))
                {
                    ArgIndex += c;
                }

                result.Append(c);
            }

            return result.ToString();

        }
    }
}


