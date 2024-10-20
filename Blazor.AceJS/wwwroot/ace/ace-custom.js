(function () {
    let previousCode = null;
    const editorCache = new Map();

    function getEditor(element) {
       /* if (!editorCache.has(element)) {
            editorCache.set(element, ace.edit(element));
        }*/
        return ace.edit(element);
    }

    function setEditorMode(editor, mode) {
        const defineMode = "ace/mode/" + mode;
        editor.session.setMode(defineMode);
    }

    window.editorRender = function (element, mode, theme, readOnly) {
        const editor = getEditor(element);

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
        const editor = getEditor(element);
        editor.setTheme("ace/theme/" + theme);
    };

    window.ace_set_mode = function (element, mode) {
        const editor = getEditor(element);
        setEditorMode(editor, mode);
    };

    window.ace_destroy = function (element) {
        const editor = getEditor(element);
        editor.destroy();
        editor.container.remove();
        editorCache.delete(element);
    };

    window.ace_set_readonly = function (element, readOnly) {
        const editor = getEditor(element);
        editor.setReadOnly(readOnly);
    };

    const debounce = (func, wait) => {
        let timeout;
        return function (...args) {
            clearTimeout(timeout);
            timeout = setTimeout(() => func.apply(this, args), wait);
        };
    };

    window.GetCode = debounce(async (dotNetHelper, element) => {
        const editor = getEditor(element);
        const code = editor.getSession().getValue();
        await dotNetHelper.invokeMethodAsync('ReceiveCode', code);
        const selectedCode = editor.getSelectedText();
        if (selectedCode !== previousCode) {
            previousCode = selectedCode;
            await dotNetHelper.invokeMethodAsync('ReceiveSelectedCode', selectedCode);
        }
    }, 20);
})();