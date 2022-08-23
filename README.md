# Blazor.AceJS

## Overview
A simple nuget package to use AceEditor.js with blazor

## Usage
1. Run `Install-Package Blazor.AceEditorJs` in the package manager console to install the latest package in your frontend project.
2. Add references to necessary js in your `index.html`
    - Add `<script src="_content/Blazor.AceEditorJs/BlazorAceEditor.js"></script>` to the body
3. Add `@using Blazor.AceEditorJs` to your page
4. Add the component to your view and build the editor like so:
    ->You can select your desirated language via the Type enum 'Languages'
    ```c#
    @page "/EditorDemo"
    @using Blazor.AceEditorJs   

    <PageTitle>EditorDemo</PageTitle>
    <AceJsEditor language="Languages.sql" Style="height:300px" @bind-Value ="@textToEdit" DarkMode="true"></AceJsEditor>
    <p>@textToEdit</p>

    @code {
        string textToEdit = "Select * from Test";
    }

    ```
5. test
![image](https://user-images.githubusercontent.com/46160493/186119032-dde36180-579a-4f68-a553-f04533c8ecba.png)
