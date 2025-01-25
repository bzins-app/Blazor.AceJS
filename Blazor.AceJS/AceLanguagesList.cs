using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.AceEditorJs
{
    public enum AceLanguage
    {
        [Display(Name = "ABAP")]
        abap,
        [Display(Name = "ABC")]
        abc,
        [Display(Name = "ActionScript")]
        actionscript,
        [Display(Name = "ADA")]
        ada,
        [Display(Name = "Alda")]
        alda,
        [Display(Name = "Apache Conf")]
        apache_conf,
        [Display(Name = "Apex")]
        apex,
        [Display(Name = "AQL")]
        aql,
        [Display(Name = "AsciiDoc")]
        asciidoc,
        [Display(Name = "ASL")]
        asl,
        [Display(Name = "Assembly x86")]
        assembly_x86,
        [Display(Name = "AutoHotkey / AutoIt")]
        autohotkey,
        [Display(Name = "BatchFile")]
        batchfile,
        [Display(Name = "C and C++")]
        c_cpp,
        [Display(Name = "C9Search")]
        c9search,
        [Display(Name = "Cirru")]
        cirru,
        [Display(Name = "Clojure")]
        clojure,
        [Display(Name = "Cobol")]
        cobol,
        [Display(Name = "CoffeeScript")]
        coffee,
        [Display(Name = "ColdFusion")]
        coldfusion,
        [Display(Name = "Crystal")]
        crystal,
        [Display(Name = "C#")]
        csharp,
        [Display(Name = "Csound Document")]
        csound_document,
        [Display(Name = "Csound")]
        csound_orchestra,
        [Display(Name = "Csound Score")]
        csound_score,
        [Display(Name = "CSS")]
        css,
        [Display(Name = "Curly")]
        curly,
        [Display(Name = "D")]
        d,
        [Display(Name = "Dart")]
        dart,
        [Display(Name = "Diff")]
        diff,
        [Display(Name = "Dockerfile")]
        dockerfile,
        [Display(Name = "Dot")]
        dot,
        [Display(Name = "Drools")]
        drools,
        [Display(Name = "Edifact")]
        edifact,
        [Display(Name = "Eiffel")]
        eiffel,
        [Display(Name = "EJS")]
        ejs,
        [Display(Name = "Elixir")]
        elixir,
        [Display(Name = "Elm")]
        elm,
        [Display(Name = "Erlang")]
        erlang,
        [Display(Name = "Forth")]
        forth,
        [Display(Name = "Fortran")]
        fortran,
        [Display(Name = "FSharp")]
        fsharp,
        [Display(Name = "FSL")]
        fsl,
        [Display(Name = "FreeMarker")]
        ftl,
        [Display(Name = "Gcode")]
        gcode,
        [Display(Name = "Gherkin")]
        gherkin,
        [Display(Name = "Gitignore")]
        gitignore,
        [Display(Name = "Glsl")]
        glsl,
        [Display(Name = "Gobstones")]
        gobstones,
        [Display(Name = "Go")]
        golang,
        [Display(Name = "GraphQLSchema")]
        graphqlschema,
        [Display(Name = "Groovy")]
        groovy,
        [Display(Name = "HAML")]
        haml,
        [Display(Name = "Handlebars")]
        handlebars,
        [Display(Name = "Haskell")]
        haskell,
        [Display(Name = "Haskell Cabal")]
        haskell_cabal,
        [Display(Name = "haXe")]
        haxe,
        [Display(Name = "Hjson")]
        hjson,
        [Display(Name = "HTML")]
        html,
        [Display(Name = "HTML (Elixir)")]
        html_elixir,
        [Display(Name = "HTML (Ruby)")]
        html_ruby,
        [Display(Name = "INI")]
        ini,
        [Display(Name = "Io")]
        io,
        [Display(Name = "Ion")]
        ion,
        [Display(Name = "Jack")]
        jack,
        [Display(Name = "Jade")]
        jade,
        [Display(Name = "Java")]
        java,
        [Display(Name = "JavaScript")]
        javascript,
        [Display(Name = "JSON")]
        json,
        [Display(Name = "JSON5")]
        json5,
        [Display(Name = "JSONiq")]
        jsoniq,
        [Display(Name = "JSP")]
        jsp,
        [Display(Name = "JSSM")]
        jssm,
        [Display(Name = "JSX")]
        jsx,
        [Display(Name = "Julia")]
        julia,
        [Display(Name = "Kotlin")]
        kotlin,
        [Display(Name = "LaTeX")]
        latex,
        [Display(Name = "Latte")]
        latte,
        [Display(Name = "LESS")]
        less,
        [Display(Name = "Liquid")]
        liquid,
        [Display(Name = "Lisp")]
        lisp,
        [Display(Name = "LiveScript")]
        livescript,
        [Display(Name = "Log")]
        log,
        [Display(Name = "LogiQL")]
        logiql,
        [Display(Name = "LSL")]
        lsl,
        [Display(Name = "Lua")]
        lua,
        [Display(Name = "LuaPage")]
        luapage,
        [Display(Name = "Lucene")]
        lucene,
        [Display(Name = "Makefile")]
        makefile,
        [Display(Name = "Markdown")]
        markdown,
        [Display(Name = "Mask")]
        mask,
        [Display(Name = "MATLAB")]
        matlab,
        [Display(Name = "Maze")]
        maze,
        [Display(Name = "MediaWiki")]
        mediawiki,
        [Display(Name = "MEL")]
        mel,
        [Display(Name = "MIPS")]
        mips,
        [Display(Name = "MIXAL")]
        mixal,
        [Display(Name = "MUSHCode")]
        mushcode,
        [Display(Name = "MySQL")]
        mysql,
        [Display(Name = "Nginx")]
        nginx,
        [Display(Name = "Nim")]
        nim,
        [Display(Name = "Nix")]
        nix,
        [Display(Name = "NSIS")]
        nsis,
        [Display(Name = "Nunjucks")]
        nunjucks,
        [Display(Name = "Objective-C")]
        objectivec,
        [Display(Name = "OCaml")]
        ocaml,
        [Display(Name = "PartiQL")]
        partiql,
        [Display(Name = "Pascal")]
        pascal,
        [Display(Name = "Perl")]
        perl,
        [Display(Name = "pgSQL")]
        pgsql,
        [Display(Name = "PHP (Blade Template)")]
        php_laravel_blade,
        [Display(Name = "PHP")]
        php,
        [Display(Name = "Pig")]
        pig,
        [Display(Name = "Powershell")]
        powershell,
        [Display(Name = "Praat")]
        praat,
        [Display(Name = "Prisma")]
        prisma,
        [Display(Name = "Prolog")]
        prolog,
        [Display(Name = "Properties")]
        properties,
        [Display(Name = "Protobuf")]
        protobuf,
        [Display(Name = "Puppet")]
        puppet,
        [Display(Name = "Python")]
        python,
        [Display(Name = "QML")]
        qml,
        [Display(Name = "R")]
        r,
        [Display(Name = "Raku")]
        raku,
        [Display(Name = "Razor")]
        razor,
        [Display(Name = "RDoc")]
        rdoc,
        [Display(Name = "Red")]
        red,
        [Display(Name = "RHTML")]
        rhtml,
        [Display(Name = "Robot")]
        robot,
        [Display(Name = "RST")]
        rst,
        [Display(Name = "Ruby")]
        ruby,
        [Display(Name = "Rust")]
        rust,
        [Display(Name = "SaC")]
        sac,
        [Display(Name = "SASS")]
        sass,
        [Display(Name = "SCAD")]
        scad,
        [Display(Name = "Scala")]
        scala,
        [Display(Name = "Scheme")]
        scheme,
        [Display(Name = "Scrypt")]
        scrypt,
        [Display(Name = "SCSS")]
        scss,
        [Display(Name = "SH")]
        sh,
        [Display(Name = "SJS")]
        sjs,
        [Display(Name = "Slim")]
        slim,
        [Display(Name = "Smarty")]
        smarty,
        [Display(Name = "Smithy")]
        smithy,
        [Display(Name = "snippets")]
        snippets,
        [Display(Name = "Soy Template")]
        soy_template,
        [Display(Name = "Space")]
        space,
        [Display(Name = "SQL")]
        sql,
        [Display(Name = "SQLServer")]
        sqlserver,
        [Display(Name = "Stylus")]
        stylus,
        [Display(Name = "SVG")]
        svg,
        [Display(Name = "Swift")]
        swift,
        [Display(Name = "Tcl")]
        tcl,
        [Display(Name = "Terraform")]
        terraform,
        [Display(Name = "Tex")]
        tex,
        [Display(Name = "Text")]
        text,
        [Display(Name = "Textile")]
        textile,
        [Display(Name = "Toml")]
        toml,
        [Display(Name = "TSX")]
        tsx,
        [Display(Name = "Twig")]
        twig,
        [Display(Name = "Typescript")]
        typescript,
        [Display(Name = "Vala")]
        vala,
        [Display(Name = "VBScript")]
        vbscript,
        [Display(Name = "Velocity")]
        velocity,
        [Display(Name = "Verilog")]
        verilog,
        [Display(Name = "VHDL")]
        vhdl,
        [Display(Name = "Visualforce")]
        visualforce,
        [Display(Name = "Wollok")]
        wollok,
        [Display(Name = "XML")]
        xml,
        [Display(Name = "XQuery")]
        xquery,
        [Display(Name = "YAML")]
        yaml,
        [Display(Name = "Zeek")]
        zeek,
        [Display(Name = "Django")]
        django
    }
}
