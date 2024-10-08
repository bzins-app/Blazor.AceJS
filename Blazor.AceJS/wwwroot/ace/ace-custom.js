(function () {
    let previousCode = null;

    function getEditor(element) {
        return ace.edit(element);
    }

    function setEditorMode(editor, mode) {
        var defineMode = "ace/mode/" + mode;
        editor.session.setMode(defineMode);
    }

    window.editorRender = function (element, mode, theme, readOnly) {
        var editor = getEditor(element);

        editor.setTheme("ace/theme/" + theme);
        editor.setReadOnly(readOnly);
        setEditorMode(editor, mode);
        editor.renderer.setScrollMargin(10, 10);

        // enable autocompletion and snippets
        editor.setOptions({
            autoScrollEditorIntoView: true,
            enableBasicAutocompletion: true,
            enableSnippets: true,
            enableLiveAutocompletion: true
        });
    };

    window.ace_set_theme = function (element, theme) {
        var editor = getEditor(element);
        editor.setTheme("ace/theme/" + theme);
    };

    window.ace_set_mode = function (element, mode) {
        var editor = getEditor(element);
        setEditorMode(editor, mode);
    };

    window.ace_destroy = function (element) {
        var editor = getEditor(element);
        editor.destroy();
        editor.container.remove();
    };

    window.ace_set_readonly = function (element, readOnly) {
        var editor = getEditor(element);
        editor.setReadOnly(readOnly);
    };

    window.GetCode = (dotNetHelper, element) => {
        var editor = getEditor(element);
        var code = editor.getSession().getValue();
        dotNetHelper.invokeMethodAsync('ReceiveCode', code);
    };

    window.GetSelectedCode = (dotNetHelper, element) => {
        var editor = getEditor(element);
        var code = editor.getSelectedText();
        if (code !== previousCode) {
            previousCode = code;
            dotNetHelper.invokeMethodAsync('ReceiveSelectedCode', code);
        }
    };
})();