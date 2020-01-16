
window.JsRuntimeExtensions = {
     /// ---- cookies -----
    WriteCookie: function (cname, cvalue, cdays) {

        var expires;
        if (cdays) {
            var date = new Date();
            date.setTime(date.getTime() + (cdays * 24 * 60 * 60 * 1000));
            expires = "; expires=" + date.toGMTString();
        }
        else {
            expires = "";
        }
        document.cookie = cname + "=" + cvalue + expires + "; path=/";
    },

    ReadCookie: function (cname) {
        var name = cname + "=";
        var decodedCookie = decodeURIComponent(document.cookie);
        var ca = decodedCookie.split(';');
        for (var i = 0; i < ca.length; i++) {
            var c = ca[i];
            while (c.charAt(0) == ' ') {
                c = c.substring(1);
            }
            if (c.indexOf(name) == 0) {
                return c.substring(name.length, c.length);
            }
        }
        return "";
    },

    ClearCookie: function (cname) {
        this.WriteCookie(cname, null, -1);
    },

    /// ---- end cookies -----

    /// ---- local storage -----
    SetInLocalStorage: function (key, content) {
        localStorage.setItem(key, content);
    },
    GetFromLocalStorage: function (key) {
        return localStorage.getItem(key);
    },

    RemoveFromLocalStorage: function (key) {
        localStorage.removeItem(key);
    }

    /// --- end local storage

}

