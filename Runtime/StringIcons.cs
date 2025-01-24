using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace ReirenCore.Icons
{
    using ExtensionMethods;
    /// <summary>
    /// d_FilterByType<br/>
    /// Dreieck nach unten Symbol. 
    /// </summary>
    public class ImageSelector : Image
    {
        public ImageSelector()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("d_FilterByType").ToSprite();
        }
    }
    /// <summary>
    /// Toolbar Plus
    /// </summary>
    public class ImageAdd : Image
    {
        public ImageAdd()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("Toolbar Plus").ToSprite();
        }
    }
    /// <summary>
    /// Toolbar Minus
    /// </summary>
    public class ImageRemove : Image
    {
        public ImageRemove()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("Toolbar Minus").ToSprite();
        }
    }
    /// <summary>
    /// CollabConflict
    /// </summary>
    public class ImageError : Image
    {
        public ImageError()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("CollabConflict").ToSprite();
        }
    }
    /// <summary>
    /// MetadataON
    /// </summary>
    public class ImageArg : Image
    {
        public ImageArg()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("MetadataON").ToSprite();
        }
    }
    /// <summary>
    /// d_winbtn_win_close<b\>
    /// Kreuz
    /// </summary>
    public class ImageClose : Image
    {
        public ImageClose()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("d_winbtn_win_close").ToSprite();
        }
    }

    /// <summary>
    /// d_PlayButton<b\>
    /// </summary>
    public class ImagePlay : Image
    {
        public ImagePlay()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("d_PlayButton").ToSprite();
        }
    }

    /// <summary>
    /// d_PreMatQuad<b\>
    /// Audio Pause
    /// </summary>
    public class ImagPause : Image
    {
        public ImagPause()
        {
            this.AddToClassList("Enum-Icon");
            this.sprite = EditorGUIUtility.FindTexture("d_PreMatQuad").ToSprite();
        }
    }



    /// <summary>
    /// Bilder welche keine ohne Asset generiert werden k�nnen
    /// </summary>
    static public class StringIcons
    {
        public static string Setting16 = "iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8/9hAAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAAdgAAAHYBTnsmCAAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAMASURBVDiNdZJLaFxlHMV/3537nJuZSUwkk0erjbRaX5DYQqloHFy40IUuBEFEF4LuRdy476brShdmo6siIqW6UdFdiZWC1AQpFTNpOklmkknmzr137vP7u0pW7VmdxTlwDufAI9AL5Xo3kHAnkHB7INcfpTOOiIjY/VAuHUSyKCKWaF7S4Ivga5GlP0WsjQNZbPfLS2si9pFPAdwX8fyIHwVaWhiKECWaZqEFRDCUwjDY0RpfoKaFX/Vj6s3TSqUmwPbdYGVhtt4SIC2p9eKydns3YTcSlChmPcX5E27TNRUC9IP09d5m8i3wrgFwGBfft7tRnJawvpdyrZ2yFpn0E0U3VtzsVLi6mtEZlAhwGOSjLNffHVcQEbsbSLsT6+a1jZQiFaaHAyYcwfcsiorNrR2XIld8fEHhedZO+Lg6eU6pXPVCuSGapUQz8/N/EX+HJnOH+5ycMPP5qbFPK45Rlln51SCteN+sKs7PJrz6nINbtbe1VrdN0SxrGCu00I2FSlow4Qhzk7XPLj5TXQG48yCrTDX4etwV+qHF6p0u515szriOuWzsh6kRJQWIQKkoS4XvWVRsKY+m8k0j910TnYFohWNXuNfu0x+MKua9zeF9xzZnzjzZqM94io0Dg3zMRhdyeX2n2DcMtGWqKw/2odPTnDlb4FdNkqxMtjrDXQWwJmLXBtIORtK8/FMAJby9ZPPsvIXvmvzb0Vy5EZHnwnvLGV7VGjy9OD59WqlUAWwcyCIiv2uh/s/WiKs/bBGFGb5nIyUEwwzPtXmnNc7ctI3r2rHrWK+9/JR9ywCIo/TDYZzXh3HO/JTFlx+c4OwTCpXvYRR7PL9g8NFbDaYnTagYGAZVhX7/+Ae/ibisD//IC/1CEOVZ3bdGoqVxd3OAbRnYloFlm6M009Z43TFdx/qr2qhdaJ1SiQHQUiopRsUrvcPkZprkn1v1RnNvmMZjYzZ5WZJr0oWF6UlD9BdBlK3qIrzYOqWS4wQPw8ovW1thVMwCOK7V/eSNuebDdP8DgSSRwMpUeZ4AAAAASUVORK5CYII=";
        public static string Setting24 = "iVBORw0KGgoAAAANSUhEUgAAABgAAAAYCAYAAADgdz34AAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAAsQAAALEBxi1JjQAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAVLSURBVEiJjZVJjJzFFcd/VfWt3T0zPWbGbXs84OBNFoQIEjBECMk2ixQklENklBuKkgscTJSDpYiDD3BCKImQckhO4RAlSEERiRSBIiaKIrLAgIOdQPDCjLeZ6Zl2d8/08nV/VfVy6Gnb0IbkSU+lKr33/1e9rRT/h6xtyPMCR0XYIYAIV4BXt02o5/6Xr77ZoYioG/cejoiwV6AoQlFgrxM58kU+n0tQb8sT9Ta1WkuOAVSrUkKobN6cwSp4qFSrUgJYrMuxxbrUztflic/ifYq13pJnBV4S0CKIhz8i3CtQ9h7cJvjQS4SGwDsiPCygRPBe1LN7ptTLIwTnl/vfLZfCn20aMrxx2wodKzg/MFZqoKFSGAOG67YC5Nb7eiP7zgP7S7+4RjA3NxeoLV9Zn60U04liNDD0UM88jZ5jfqXHSqboeo13kHhhZwpf3xUxlphrJP2+p1rvUt/oZSfvu6V4QimvAQ4dOmQzK7++UO2IdULuYa3rObXW4/Uly0Ie0pYA6zS51TT7hlM1w8/fsZy+nA/DhUdYbWTkVn5zQik/koMPFjp/rWxJ7x+Cz7c0zoHJcspZh5LyRIEmUyEXugnNTCMOHt8HX9sV0fdQvdr9+4P7iveP5KBalRIJF9tWyldalteXLLnTJK0u27J1klATR2agoSGONO+uJJxZ04QI377bcvv2Irmn4UTN3rFVtQCCtQ15QeAxhCkP5Y4V3lvpkbsQk+Vsy9ZJQ81MpXhxvBS/YATvcMdtLrsf2e2pbWiqTcU/zgkh61S2jpUVcupfK67mFW+o1Q05I8IeAbyH1czzq7NdOj5gutVkWvWZqRSWHr/nlh03hvP9he5Zrdn94bLmtXmhUhJuTS5z1/4pdlbG8IO8nNUibB+WmduMWeY03sKY8sSRoTwW/+SzDRSF5sdpZPjSVoO3UFtXiMDHn9RZvtodlu32oN2ziEAYakChFIgDZyEMNHEEWmm5CYHEIZgMvAWvoRAb4jjk8soGXjylUiz60kqntbjcprHeh80mirzgLWQqJA4NLrdPjxAE6plAKRZXBWehnAjFNCRODArF0nKbpaV2FjS6dr7T6d/Xd86UJ+LJUCl2RFBrCud7CfsmM6yT204uZh+GYfB8QeN0pH8Yag44p3jjpMX1hZlJSyEJIDB0s7yd596aXv7BtTI9d04mwi2yYIVyre14+c0O/Rxmy4pv3q0ppYY0MiSxIVAKa+Gnf8j455mc0CiOPpRRSDVBqLuFQjD78IHx2kijLdb9myI8kgv8+XSL377dwHsoJQEPHihwx64EjeLfC33mTra42sgRD48eLHDnbeCNIYnMu49+efzekUZbrMsxEfnRcNgB/P5va/zuT5fIc0FkMHBkU/FgjOHIwSnu2Z/gjSEKDXEcSJrq4wdnkxevEYiI/s9yftXDhMh17jTWnD7f5LW3LnLhUo1Ouw0CaaHIrpkpHvrqFFPlCKcUwWanR1FAHJnmwVujSaXU9V9o/pPOk3nuf+lBMxzXQCkNqDUz3vtoDZFBKRbTkCQ2aK0RFEYrosQQBYYoNKIinjq8p/TKSA7eOt18qZf77wui1uo9KaTBuSQ2Mwhpo9VjtdYhCgN0oAm0IgxNDlLtdvOZ8VJMsRhJFOkXv3FX+fgQ81Nf5uE7J34gwokr1Y7t5/Yv33pgem+SBrOdnm1qpRgfS/AiiBNQ0p2c1rNPHd6xUxvz9nqr53q5fe5G8JEXDOVVEXNUKTfcvzK3VO327DQCznmcE5LENL732Ozk5/kMJbgZwaihfORyN9F3EgIESllt1Mdf7DOQ/wIdJ8hTMs9EjAAAAABJRU5ErkJggg==";
        public static string Setting32 = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAABHNCSVQICAgIfAhkiAAAAAlwSFlzAAAA7AAAAOwBeShxvQAAABl0RVh0U29mdHdhcmUAd3d3Lmlua3NjYXBlLm9yZ5vuPBoAAAgQSURBVFiFlZf7j11VFcc/+3Eed96005nptFRKC52itpZgbbU2IhixQIgGiEFJJJFETPT/MPEnjfiMMSXqD9VQEwETrVUTHlJoSqBgoe1AO2M773vnPs49j72XP5yZ2+l0GjM72TnJPtnr+13ru9Y66yjWuebq8piH7wNDImwRwMMkwjTCjzYPqGPrsWfXS8AL30JxSASEciPcCdwpShaBdRHQN3sxLhIvNOUREYlWv1sJLrJ0xtLhivWBSHRpQR4ZH5d4XQSmGzLS3+CkCMfnmxwfl9LAVEOGBXavBS4CDnZfrcsQwPi4xEFNjnuR4/TLyfFpGVkLS60+mG/IHuAFYOsyiIfXFIyL8FWBeC3wjhzQFuR5UNu958ByUESYEKWO7Nig3r4pgWpVdojlZYHhZZAVBhCBthfaBTgpgZUCrcAohdWCQSFqjbslwYlm0j64d2vXxA0ETk5Lz3DafmN4IN7FKgNeoFUIi7kgvjybbRZUM48SYaBiGOm2GK3QgNUlsVXgVOsp9WZ+PjC9dx8aU3VYUQVqauGZKc8uAYb64w41LzDXFlInVNuO16dTZp2h8BrvFOIU3gnGpYxEwuHbQoZ6DXopOsvg84spi/WMaiPbGZriu8APYEUS2uCWnzUzd35qPmGhmQPgBKYTT9sJr15p89K0Y9oHS+AgDvzSTp3mw7rh6FuOE+dSZDkCS1FIM8dCPaUo3Id2Tn66jNshcGhM1aMN5p4085d7KwYvsNAWcg9/m0gYLwzOK7wDCqErTdmQtdjkEgbI0V7wDgoH/55UHDudIoBZsr9xIEa8XIlctO/IkY2LayYhwMScPxYG6tFmIVTT0vPxwnQ87m40GMxaRFYRWEUYGAKrUcZyoRFyvhp0onLPqOfhvRGCIveQFu7Yns3B4yvxrusDUw0ZDgP1kAgs5qXmH+bXwn1LrcpQ2rgBPAwMXQHcM1xwaDTvSHPqI80r71QxWhAFgTUPn79a9omO9HN1eczB0wqUeHYKxG1fZvvr0ynOlx71NBoMFG2CwBCHiq1DvW92d5kfW218mvlnkjQ7GBjN2JCi2hbeuKQQB+fmYuzbM+y7axNOiDMtr52d8RfwiFP+l9bD9xR8fmW5tIulUnMG70vNB7MWQWCIQs3OLX3fObS79+crHHnuzET2ZJLkRwOjOLxTceYSpA4+mrN05028wJ6xQVBqu3jZLoAWYg1sXt3bnQgzzaKT7XGWdcK+Zajn3VXgAHxqa/hcV2xfi0NNX6zZvrFM2EYiYCIuTzV469ws4lf2F7VZizByQ28XqGW+o30krqN5d8UcXQ2+vKLQHg2tJgoNQz3XcgcCAqOZr6W8/9ECSKd9j+jceZU5T1b4pSgISoES6SST4lrCGaXdzQgYIAoNVqsSYOm+1oo4MoSBoVZPuTi5SF54CueVvTqfVr2XboDBgYgw0GgF/bHBu7K2U2wn2/O8+CbwwzUJaP+E1QalYLoqnXIMrScODUorjNVUaylFLvT3RVU9W223pxYSphYSFptZ2TyUYnOPxbhShmpuUcYSGEWa+b1nJrInV4N/cKV4LLLmkFKQpIr3Jsq7Favoi4vSgbBsS3nhqdVTZucbzjonv222i6eUeDW9oCsbBuKNVgtOFJssjDfAe8W5WsSB0RxrFK0kO/r25eypwOpndWjEKr4danlAqVKu46cK2knp/fZRRxxodGDQRpMneQMvidfKi+jfX9cJz11ubenqjc+LJ247mFwo+PXLGYUX8IpD2z37tmlCq4nD8rms+TL4iXdyfnciwztBAV87kDDYLzitiaIgVwVjD3164OIy5nWdcNetXZOCPC+q/KRu3WAZGyxIFlski03+eibhhdM5hagbwOst+Mmf6xx9cYEsaZKnLfZuy9g0IChjCANLaMw/V4LDqqF0fFxi7+V2WBo0BB4/2MvkVIuLl5qIwKkqnD6rGB2MGOwPQWC2WnDpapui8GWdC+zYUmH/biGwFqcNgTUEoRp55bJUPnurSpYxOxJ8IBIFNTmO54GVkwyAB559/hKn35lGfFnDnRl0aVLqPJVi39gQX9xfoRIYCmWw1hCGhjDQWGtODObBg3fcodLrCVwpHvXIsQ74ih1bjdbw0qtXOPnmFP+dmCXP82uhE7A2ZHR0kMN3D7JtJMIaQ47CWkMQaEJrsEvNDHj0wG3RH6+ToDY5/aIe3PCWiN+7ep5rApXI8JWDI2zss4xf6aNWdyRpgVKK/p6QbcMxldAQRYbCQ+o91hhEBO+FwjmU0qQi77aTrr/cIAHAy+8mH3Pkb3hhcNn7wnm0UqgyzekOLRcmqkzOtAiMJooMUaDLZNQaD1hr0ErjxdMVB1irsFajlJoPVbj/vk/GF9YkAPCP/9TvbbXzP3knvXnhqTUyisLXRjZ1nRWv9gtiPcLUTItW22GNQiuFsQqjFdZaHwb6bLXWvl1ruitxQE9PiDG62tUVPPLlu3r/tRLvhh+TL4z1ngzF3JekbmZmIaXdzqt9zt7x0N0bP1cJ9a4s89Wk7ejriajEZYhFlYmptW5VuoJPfOPw8J5beoLbRKg1k5yk5abC7q7PrAZfkwDA/fv6T8VpfFdo9S+GIrvz8SObZwDu3zNwMXduLklyWu2cwCqMUXgvOC+AVL9+cPA9gCfuHZ0dic2OSqh/5V3+8Qd3x++vhXWDBP9v/ebvVy41mtmtK8+cEwTo7g6vPv2l0c3rsXfTn9ObrTjQxwKra0CW5U6y3IkxKosCVY9D9Yf12vsfIIR87/QGS8gAAAAASUVORK5CYII=";
        
        /// <summary>
        /// Generiert ein Sprite anhand eines Base64String
        /// </summary>
        /// <param name="Base64String"></param>
        /// <returns></returns>
        public static Sprite GetSprite(string Base64String)
        {
            Texture2D Tex = new Texture2D(16, 16);
            Tex.LoadImage(Convert.FromBase64String(Base64String));
            return Tex.ToSprite();
        }
    }



}

