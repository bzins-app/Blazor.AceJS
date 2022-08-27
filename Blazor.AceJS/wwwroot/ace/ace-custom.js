
window.editorRender = function (element, mode, theme, readOnly){
    var editor = ace.edit(element);
    var dragging = false;
    var wpoffset = 0;
    var defineMode = "ace/mode/" + mode;

    editor.setTheme("ace/theme/" + theme);
    editor.setReadOnly(readOnly);
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

window.ace_set_theme = function (element, theme) {
    var editor = ace.edit(element);
    editor.setTheme("ace/theme/" + theme);
}

window.ace_set_mode = function (element, mode) {
    var editor = ace.edit(element);
    var defineMode = "ace/mode/" + mode;
    editor.session.setMode(defineMode);
}

window.ace_destroy = function ace_destroy (element) {
    var editor = ace.edit(element);
    editor.destroy();
    editor.container.remove();
}

window.ace_set_readonly = function (element, readOnly) {
    var editor = ace.edit(element);
    editor.setReadOnly(readOnly);
}

window.GetCode = (dotNetHelper, element) => {
    var editor = ace.edit(element);
    var code = editor.getSession().getValue();
    dotNetHelper.invokeMethodAsync( 'ReceiveCode', code)
};

