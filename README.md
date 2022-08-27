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
    
5. test
![image](https://user-images.githubusercontent.com/46160493/186119032-dde36180-579a-4f68-a553-f04533c8ecba.png)


-> you can update the Ace options in using the method 'AceJsEditor.SetAceEditorParameters(AceEditorOptions)' . Don't hesitate to see the demo project to see interactions.

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
   
   Multi editor instances can be also rendered on the same page with differents configurations.
   
![image](https://user-images.githubusercontent.com/46160493/187048810-d0474300-73be-412f-88ae-04bb7fab1da6.png)


The list of themes and languages for enum 'AceLanguage' and 'AceTheme' can be retrieved in the demo project but also here:https://ace.c9.io/tool/mode_creator.html

![image](https://user-images.githubusercontent.com/46160493/187050691-8b3e765c-19c0-4ec5-8b4f-c79425b4bd7b.png)
