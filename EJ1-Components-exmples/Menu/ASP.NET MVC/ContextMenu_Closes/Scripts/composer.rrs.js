
// following function is used to find if array conatins the record which I want to search
var indexOf = function (needle) {
    if (typeof Array.prototype.indexOf === 'function') {
        indexOf = Array.prototype.indexOf;
    } else {
        indexOf = function (needle) {
            var i = -1, index = -1;
            for (i = 0; i < this.length; i++) { if (this[i] === needle) { index = i; break; } }
            return index;
        };
    }
    return indexOf.call(this, needle);
};

// below function is used as a workaround for getting thee size of the object in javascript. 
Object.size = function (obj) {
    var size = 0, key;
    for (key in obj) {
        if (obj.hasOwnProperty(key)) size++;
    }
    return size;
};

//Check If HelpFile Exists
function returnHelpFile(urlToFile, fileType) {
    var xhr = new XMLHttpRequest();
    xhr.open('HEAD', urlToFile, false);
    xhr.send();

    if (xhr.status == "404") {
        //alert(fileType + " does not exists");
        $('#helpErrorModal').modal();
        //$('#errorMessage').innerHTML = fileType + " does not exists";
        document.getElementById('errorMessage').innerHTML = "<h3 style=\"text-align: center;\">" + fileType + " does not exists</h3>";
    } else {
        //return true;
        $('helpFileLink').href = urlToFile;
        window.location.href = urlToFile;
    }
}



//#region Start: for positioning the syncfusion dialog window
function positionedDialogWindow(dialogName) {
    var windowpostop = $(window).scrollTop();
    var windowposleft = $(window).scrollLeft();
    $("#" + dialogName + "").ejDialog({ position: { X: windowposleft + 400, Y: windowpostop + 150 } });
}

function positionedRuleInfoWindow(dialogName) {
    var windowpostop = $(window).scrollTop();
    var windowposleft = $(window).scrollLeft();
    $("#" + dialogName + "").ejDialog({ position: { X: windowposleft + 300, Y: windowpostop - 120 } });
}
function positionedGridWindow(dialogName) {
    var windowpostop = $(window).scrollTop();
    var windowposleft = $(window).scrollLeft();
    $("#" + dialogName + "").ejDialog({ position: { X: windowposleft + 300, Y: windowpostop + 50 } });
}

function positionedLargeWindow(dialogName) {
    var windowpostop = $(window).scrollTop();
    var windowposleft = $(window).scrollLeft();
    $("#" + dialogName + "").ejDialog({ position: { X: windowposleft + 100, Y: windowpostop + 50 } });
}
//#endregion End: for positioning the syncfusion dialog window


