

function editorRender(element,modeSQL,theme) {
    var editor = ace.edit(element);
    var dragging = false;
    var wpoffset = 0;
    var defineMode = "ace/mode/" + modeSQL;

    editor.setTheme("ace/theme/" + theme);
    // inline must be true to syntax highlight PHP without opening <?php tag
    editor.session.setMode(defineMode);
    editor.renderer.setScrollMargin(10, 10);
    editor.setOptions({
        // "scrollPastEnd": 0.8,
        autoScrollEditorIntoView: true
    });
    // enable autocompletion and snippets
    editor.setOptions({
        enableBasicAutocompletion: true,
        enableSnippets: true,
        enableLiveAutocompletion: true
    });

};


window.GetCode = (dotNetHelper, element) => {
    var editor = ace.edit(element);
    var code = editor.getSession().getValue();
    dotNetHelper.invokeMethodAsync( 'ReceiveCode', code)
};


