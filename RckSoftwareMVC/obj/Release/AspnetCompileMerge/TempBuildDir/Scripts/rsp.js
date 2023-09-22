// Rich Single Page
var Rsp = function () {
    var _loaderOn = null;
    var _loaderOff = null;
    var _countLoader = 0; // item personalizado para hubert
}

/*Rsp.prototype.f = function (field, value) {
    this._field = field;
    this._value = value;
};

Rsp.prototype.q = function (query) {
    this._query = query;
};*/

Rsp.prototype.serialize = function (source) {
    return $(source + " input, " + source + " select, " + source + " textarea").serialize();
};

Rsp.prototype.get = function (source, url, target) {
    this.exec(source, "GET", url, target);
}

Rsp.prototype.post = function (source, url, target) {
    this.exec(source, "POST", url, target);
}

Rsp.prototype.exec = function (source, method, url, target) {

    this._url = url;
    this._type = method;

    var data = "";

    if (({}).toString.call(source) == "[object FormData]" || ({}).toString.call(source) == "[object Object]") {
        data = source;
    }
    else if (({}).toString.call(source) == "[object String]") {
        data += $(source + " input, " + source + " select, " + source + " textarea").serialize();
    }

    this.loaderOn();

    var callback = null;
    if (({}).toString.call(target) == "[object Function]") {
        callback = target;
    }
    else if (({}).toString.call(target) == "[object String]") {
        callback = function (response) {
            $(target).html(response);
        };
    }

    $.ajax({
        type: this._type,
        url: this._url,
        data: data
    })
        .done(callback)
        .fail(this._loaderOff)
        .always(this._loaderOff);
}

Rsp.prototype.loader = function (loaderOn, loaderOff) {
    this._loaderOn = loaderOn;
    this._loaderOff = loaderOff;
    this._countLoader = 0;// item personalizado para hubert
}

Rsp.prototype.loaderOn = function () {
    if (this._loaderOn !== undefined) {
        this._loaderOn();
        this._countLoader++;// item personalizado para hubert
    }
}

Rsp.prototype.loaderOff = function () {
    if (!isNaN(this._countLoader)) {
        this._countLoader--;// item personalizado para hubert
        if (this._countLoader <= 0 && this._loaderOff !== undefined) {
            this._loaderOff();
        }
    } else {
        this._loaderOff();
    }
}

var rsp = new Rsp();