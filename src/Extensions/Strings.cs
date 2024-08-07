﻿namespace Meep.Tech.Text {

    /// <summary>
    /// Extension methods for ANSI strings.
    /// </summary>
    public static class ANSIStringExtensions {

        /// <inheritdoc cref="ANSI.AddColor(string, ANSI.Color, bool)"/>
        public static string Color(this string text, ANSI.Color color)
            => ANSI.AddColor(text, color);

        /// <inheritdoc cref="ANSI.AddColor(string, ANSI.RGB, bool)"/>
        public static string Color(this string text, ANSI.RGB color)
            => ANSI.AddColor(text, color);

        /// <inheritdoc cref="ANSI.AddBg(string, ANSI.Bg, bool)"/>
        public static string Bg(this string text, ANSI.Bg bg)
                => ANSI.AddBg(text, bg);

        /// <inheritdoc cref="ANSI.AddBg(string, ANSI.Color, bool)"/>
        public static string Bg(this string text, ANSI.Color bg)
                => ANSI.AddBg(text, bg);

        /// <inheritdoc cref="ANSI.AddBg(string, ANSI.RGB, bool)"/>
        public static string Bg(this string text, ANSI.RGB bg)
                => ANSI.AddBg(text, bg);

        /// <inheritdoc cref="ANSI.AddEffect(string, ANSI.Effect, bool)"/>
        public static string Effect(this string text, ANSI.Effect effect)
            => ANSI.AddEffect(text, effect);

        /// <inheritdoc cref="ANSI.Bold(string, bool)"/>
        public static string Bold(this string text)
            => ANSI.Bold(text);

        /// <inheritdoc cref="ANSI.Italic(string, bool)"/>
        public static string Italic(this string text)
            => ANSI.Italic(text);

        /// <inheritdoc cref="ANSI.Underline(string, bool)"/>
        public static string Underline(this string text)
            => ANSI.Underline(text);

        /// <inheritdoc cref="ANSI.Stylize(string, ANSI.Color?, ANSI.Bg?, ANSI.Effect?, bool)"/>
        public static string Style(
            this string text,
            ANSI.Color? color = null!,
            ANSI.Bg? bg = null!,
            ANSI.Effect? effect = null!
        ) => ANSI.Stylize(text, color, bg, effect);

        /// <inheritdoc cref="ANSI.Stylize(string, ANSI.Color?, ANSI.Bg?, ANSI.Effect?, bool)"/>
        public static string Style(
            this string text,
            ANSI.RGB color,
            ANSI.Bg? bg = null!,
            ANSI.Effect? effect = null!
        ) => ANSI.Stylize(text, color, bg, effect);

        /// <inheritdoc cref="ANSI.Stylize(string, ANSI.Color?, ANSI.Bg?, ANSI.Effect?, bool)"/>
        public static string Style(
            this string text,
            ANSI.Color? color = null!,
            ANSI.RGB? bg = null!,
            ANSI.Effect? effect = null!
        ) => ANSI.Stylize(text, color, bg, effect);

        /// <inheritdoc cref="ANSI.Stylize(string, ANSI.Color?, ANSI.Bg?, ANSI.Effect?, bool)"/>
        public static string Style(
            this string text,
            ANSI.RGB? color,
            ANSI.RGB? bg,
            ANSI.Effect? effect = null!
        ) => ANSI.Stylize(text, color, bg, effect);

        /// <inheritdoc cref="ANSI.Clear(string)"/>
        public static string Strip(this string text)
            => ANSI.Clear(text);

        /// <inheritdoc cref="ANSI.Reset(string)"/>
        public static string Reset(this string text)
            => ANSI.Reset(text);
    }
}
