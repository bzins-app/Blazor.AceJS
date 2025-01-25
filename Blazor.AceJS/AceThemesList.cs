using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.AceEditorJs
{

    public enum AceThemeType
    {
        Bright,
        Dark
    }

    public enum AceTheme
    {
        [Display(Name = "Chrome")]
        chrome,
        [Display(Name = "Clouds")]
        clouds,
        [Display(Name = "Crimson Editor")]
        crimson_editor,
        [Display(Name = "Dawn")]
        dawn,
        [Display(Name = "Dreamweaver")]
        dreamweaver,
        [Display(Name = "Eclipse")]
        eclipse,
        [Display(Name = "GitHub")]
        github,
        [Display(Name = "iPlastic")]
        iplastic,
        [Display(Name = "Solarized Light")]
        solarized_light,
        [Display(Name = "TextMate")]
        textmate,
        [Display(Name = "Tomorrow")]
        tomorrow,
        [Display(Name = "Xcode")]
        xcode,
        [Display(Name = "Kuroir")]
        kuroir,
        [Display(Name = "Katzenmilch")]
        katzenmilch,
        [Display(Name = "SQL Server")]
        sqlserver,
        [Display(Name = "Ambiance")]
        ambiance,
        [Display(Name = "Chaos")]
        chaos,
        [Display(Name = "Clouds Midnight")]
        clouds_midnight,
        [Display(Name = "Dracula")]
        dracula,
        [Display(Name = "Cobalt")]
        cobalt,
        [Display(Name = "Gruvbox")]
        gruvbox,
        [Display(Name = "GOB")]
        gob,
        [Display(Name = "Idle Fingers")]
        idle_fingers,
        [Display(Name = "KR AceThemeWithAttributes")]
        kr_theme,
        [Display(Name = "Merbivore")]
        merbivore,
        [Display(Name = "Merbivore Soft")]
        merbivore_soft,
        [Display(Name = "Mono Industrial")]
        mono_industrial,
        [Display(Name = "Monokai")]
        monokai,
        [Display(Name = "Nord Dark")]
        nord_dark,
        [Display(Name = "One Dark")]
        one_dark,
        [Display(Name = "Pastel on Dark")]
        pastel_on_dark,
        [Display(Name = "Solarized Dark")]
        solarized_dark,
        [Display(Name = "Terminal")]
        terminal,
        [Display(Name = "Tomorrow Night")]
        tomorrow_night,
        [Display(Name = "Tomorrow Night Blue")]
        tomorrow_night_blue,
        [Display(Name = "Tomorrow Night Bright")]
        tomorrow_night_bright,
        [Display(Name = "Tomorrow Night Eighties")]
        tomorrow_night_eighties,
        [Display(Name = "Twilight")]
        twilight,
        [Display(Name = "Vibrant Ink")]
        vibrant_ink
    }
    

    public class AceThemeWithAttributes
    {
        public AceTheme Name { get; set; }
        public string? DisplayName { get; set; }
        public AceThemeType Type { get; set; }
    }

     public static class AceThemeRepository
    {
        public static List<AceThemeWithAttributes> GetThemes()
        {
            return new List<AceThemeWithAttributes>
            {
                new AceThemeWithAttributes { Name = AceTheme.chrome, DisplayName = "Chrome", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.clouds, DisplayName = "Clouds", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.crimson_editor, DisplayName = "Crimson Editor", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.dawn, DisplayName = "Dawn", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.dreamweaver, DisplayName = "Dreamweaver", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.eclipse, DisplayName = "Eclipse", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.github, DisplayName = "GitHub", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.iplastic, DisplayName = "iPlastic", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.solarized_light, DisplayName = "Solarized Light", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.textmate, DisplayName = "TextMate", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.tomorrow, DisplayName = "Tomorrow", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.xcode, DisplayName = "Xcode", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.kuroir, DisplayName = "Kuroir", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.katzenmilch, DisplayName = "Katzenmilch", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.sqlserver, DisplayName = "SQL Server", Type = AceThemeType.Bright },
                new AceThemeWithAttributes { Name = AceTheme.ambiance, DisplayName = "Ambiance", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.chaos, DisplayName = "Chaos", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.clouds_midnight, DisplayName = "Clouds Midnight", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.dracula, DisplayName = "Dracula", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.cobalt, DisplayName = "Cobalt", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.gruvbox, DisplayName = "Gruvbox", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.gob, DisplayName = "GOB", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.idle_fingers, DisplayName = "Idle Fingers", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.kr_theme, DisplayName = "KR AceThemeWithAttributes", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.merbivore, DisplayName = "Merbivore", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.merbivore_soft, DisplayName = "Merbivore Soft", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.mono_industrial, DisplayName = "Mono Industrial", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.monokai, DisplayName = "Monokai", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.nord_dark, DisplayName = "Nord Dark", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.one_dark, DisplayName = "One Dark", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.pastel_on_dark, DisplayName = "Pastel on Dark", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.solarized_dark, DisplayName = "Solarized Dark", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.terminal, DisplayName = "Terminal", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.tomorrow_night, DisplayName = "Tomorrow Night", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.tomorrow_night_blue, DisplayName = "Tomorrow Night Blue", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.tomorrow_night_bright, DisplayName = "Tomorrow Night Bright", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.tomorrow_night_eighties, DisplayName = "Tomorrow Night Eighties", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.twilight, DisplayName = "Twilight", Type = AceThemeType.Dark },
                new AceThemeWithAttributes { Name = AceTheme.vibrant_ink, DisplayName = "Vibrant Ink", Type = AceThemeType.Dark }
            };
        }
    }

}
