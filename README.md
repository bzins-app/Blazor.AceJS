# Blazor.AceJS

## Overview
A simple nuget package to use AceEditor.js with blazor

## Usage
1. Run `Install-Package Blazor.AceEditorJs` in the package manager console to install the latest package in your frontend project. Also available here: https://www.nuget.org/packages/Blazor.AceEditorJs
2. Add references to necessary js in your `index.html`
    - Add `<script src="_content/Blazor.AceEditorJs/BlazorAceEditor.js"></script>` to the body
3. Add `@using Blazor.AceEditorJs` to your page
4. Add the component to your view and build the editor like so:
    ->select edotir ith the class 'AceEditorOptions' to select the theme, the language and the property 'ReadOnly'.
    ```c#
    @page "/EditorDemo"
    @using Blazor.AceEditorJs   

    <PageTitle>EditorDemo</PageTitle>
    <AceJsEditor  Style="height:300px" @bind-Value ="@textToEdit" Options="opt"></AceJsEditor>
    <p>@textToEdit</p>

    @code {
        string textToEdit = "Select * from Test";
        AceEditorOptions opt = new() { IsReadOnly = false, Language = AceLanguage.sqlserver, Theme = AceTheme.sqlserver };
    }

    ```
    The list of themes and languages for enum 'AceLanguage' and 'AceTheme' can be retrieved in the demo project but also here:https://ace.c9.io/tool/mode_creator.html
    
5. test
![image](https://user-images.githubusercontent.com/46160493/186119032-dde36180-579a-4f68-a553-f04533c8ecba.png)


-> you can update the options with the method 'AceJsEditor.SetAceEditorParameters(AceEditorOptions)' . Don't hesitate to see the demo project to see interactions.

    ```c#
    @page "/EditorDemo"
    @using Blazor.AceEditorJs   

    <PageTitle>EditorDemo</PageTitle>
    <AceJsEditor @ref="reference" Style="height:300px" @bind-Value ="@textToEdit" Options="opt"></AceJsEditor>
    <p>@textToEdit</p>

    @code {
        string textToEdit = "Select * from Test";
        AceJsEditor? reference;
        AceEditorOptions opt = new() { IsReadOnly = false, Language = AceLanguage.sqlserver, Theme = AceTheme.sqlserver };
        
            private async Task ChangeTheme(ChangeEventArgs e)
    {
        string theme = e.Value.ToString();
        opt.Theme = (AceTheme)Enum.Parse(typeof(AceTheme), theme);
        await reference.SetAceEditorParameters(opt);
    }
    }

    ```
