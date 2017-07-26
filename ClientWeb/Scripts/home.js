function Login() {
    var userName = $("#userName").val();
    var password = $("#password").val();
    var postData = { "name": userName };
    $.ajax({
        url: "http://localhost/MyWebApi/api/student",
        type: "GET",
        data: postData,
        datatype: "json",
        success: function (data, textStatus) {
            alert(textStatus);
        },
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            alert(XMLHttpRequest);
            alert(textStatus);
        }
    });
}