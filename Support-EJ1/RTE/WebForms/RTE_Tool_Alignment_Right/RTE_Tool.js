ej.RTE.prototype._renderToolBarItems = function (args) {
    // this._rteId = "MainContent_RTE"; 
    this._toolBarObj.disableItemByID(this._rteId + "_" + "undo");
    this._toolBarObj.disableItemByID(this._rteId + "_" + "redo");
    // Default action when render the RTE 
    this._toolBarObj.selectItemByID(this._rteId + "_" + "justifyRight");
    //Hide the editable table icons 
    var items = this._rteToolbar.find("li.e-rteItem-addColumnLeft,li.e-rteItem-addColumnRight,li.e-rteItem-addRowAbove,li.e-rteItem-addRowBelow,li.e-rteItem-deleteRow,li.e-rteItem-deleteColumn,li.e-rteItem-deleteTable");
    if (this.model.isResponsive && items.length == 0) this._toolBarObj._liTemplte.find("li.e-rteItem-addColumnLeft,li.e-rteItem-addColumnRight,li.e-rteItem-addRowAbove,li.e-rteItem-addRowBelow,li.e-rteItem-deleteRow,li.e-rteItem-deleteColumn,li.e-rteItem-deleteTable").hide();
    else this._rteToolbar.find("li.e-rteItem-addColumnLeft,li.e-rteItem-addColumnRight,li.e-rteItem-addRowAbove,li.e-rteItem-addRowBelow,li.e-rteItem-deleteRow,li.e-rteItem-deleteColumn,li.e-rteItem-deleteTable").hide();
    return this;
}
ej.RTE.prototype._updateToolbarStatus = function (args) {
    try {
        var _isAligned = false;
        if (this.model.showToolbar) {
            //Style Tools 
            for (var i = 0; i < this._styleItems.length; i++) {
                var rtestyleid = document.getElementById(this._rteId + "_" + this._styleItems[i]);
                if (this._getCommandStatus($.trim(this._styleItems[i].toLowerCase()))) {
                    this._toolBarObj.selectItemByID(this._rteId + "_" + this._styleItems[i]);
                    rtestyleid.classList.add("e-isactive");
                } else {
                    this._toolBarObj.deselectItemByID(this._rteId + "_" + this._styleItems[i]);
                    rtestyleid.classList.remove("e-isactive");
                }
            }
            var activeAlignItem = this._toolBarObj._getActiveItem()[0].id;
            for (var i = 0; i < this._alignItems.length; i++) {
                if (activeAlignItem == this._rteId + "_" + this._alignItems[i]) {
                    this._toolBarObj.selectItemByID(this._rteId + "_" + this._alignItems[i]);
                } else {
                    this._toolBarObj.deselectItemByID(this._rteId + "_" + this._alignItems[i]);
                }
            }
            for (var i = 0; i < this._scriptsItems.length; i++) {
                var rtescriptid = document.getElementById(this._rteId + "_" + this._scriptsItems[i]);
                if (this._getCommandStatus($.trim(this._scriptsItems[i].toLowerCase()))) {
                    this._toolBarObj.selectItemByID(this._rteId + "_" + this._scriptsItems[i]);
                    rtescriptid.classList.add("e-isactive");
                } else {
                    this._toolBarObj.deselectItemByID(this._rteId + "_" + this._scriptsItems[i]);
                    rtescriptid.classList.remove("e-isactive");
                }
            }
            var rteorderid = document.getElementById(this._rteId + "_" + "orderedList");
            var rteunorderid = document.getElementById(this._rteId + "_" + "unorderedList");
            if (this._getCommandStatus('InsertOrderedList')) {
                this._toolBarObj.selectItemByID(this._rteId + "_" + "orderedList");
                rteorderid.classList.add("e-isactive");
            } else {
                this._toolBarObj.deselectItemByID(this._rteId + "_" + "orderedList");
                rteorderid.classList.remove("e-isactive");
            } if (this._getCommandStatus('InsertUnorderedList')) {
                this._toolBarObj.selectItemByID(this._rteId + "_" + "unorderedList");
                rteunorderid.classList.add("e-isactive");
            } else {
                this._toolBarObj.deselectItemByID(this._rteId + "_" + "unorderedList");
                rteunorderid.classList.remove("e-isactive");
            }

            this._updateIndentStatus();
        }
    }
    catch (error) { }
}