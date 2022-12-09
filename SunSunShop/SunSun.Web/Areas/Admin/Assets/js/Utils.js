window.Utils = {
    ValidateData: function (tag_html_id, tag_html_notify) {
        var html_tag_value = $("#" + tag_html_id).val();

        console.log("Data: " + html_tag_value);

        if (html_tag_value == null || html_tag_value == "") {
            $("#" + tag_html_notify).show();
            $("#" + tag_html_notify).text("Không được để trống!")
            $("#" + tag_html_id).css("boder", "1px solid red");
            $("#" + tag_html_id).focus();
            return;
        }
        else {
            $("#" + tag_html_notify).hide();
            $("#" + tag_html_id).css("boder", "");
        }
    },
    rootUrl: function () {
        var rooturl = 'https://localhost:44341/';
        if (location.host.toString().indexOf('localhost') >= 0) { rooturl = 'https://localhost:44341/'; }
        if (location.host.toString.indexOf('islickdeals') >= 0) { rooturl = 'https://localhost:44341/'; }
        return rooturl;
    },
}