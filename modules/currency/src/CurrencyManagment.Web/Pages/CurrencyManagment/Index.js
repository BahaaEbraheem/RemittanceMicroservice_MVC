$(function () {
    var l = abp.localization.getResource('CurrencyManagment');
    var _createModal = new abp.ModalManager(abp.appPath + 'CurrencyManagment/Create');
    var _updateModal = new abp.ModalManager(abp.appPath + 'CurrencyManagment/Update');



    var _dataTable = $('#CurrenciesTable').DataTable(
        abp.libs.datatables.normalizeConfiguration({
            serverSide: true,
            paging: true,
            order: [[1, "asc"]],
            searching: false,
            scrollX: true,
            processing: true,
            autoWidth: false,
            scrollCollapse: true,
            order: [[1, "desc"]],
            ajax: abp.libs.datatables.createAjax(currencyManagment.currencies.currency.getList),
            columnDefs: [
                {
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Update'),
                                    //visible: abp.auth.isGranted('CurrencyManagment.Update'),
                                    action: function (data) {
                                        debugger
                                        _updateModal.open({
                                            id: data.record.id
                                        });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                   // visible: abp.auth.isGranted('CurrencyManagment.Delete'),
                                    confirmMessage: function (data) { return l('CurencyDeletionWarningMessage'); },
                                    action: function (data) {
                                        currencyManagment.currencies.currency
                                            .delete(data.record.id)
                                            .then(function () {
                                                _dataTable.ajax.reload();
                                            });
                                    }
                                }
                            ]
                    }
                },
                {
                    title: l('Name'),
                    data: "name"
                },
                {
                    title: l('Symbol'),
                    data: "symbol",
                  
                },
                {
                    title: l('Code'),
                    data: "code",
                  
                },
           
                {
                    title: l('CreationTime'), data: "creationTime",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
                }
            ]
        })
    );
    $("#CreateNewCurrencyButtonId").click(function () {
        _createModal.open();
    });

    _createModal.onClose(function () {
        _dataTable.ajax.reload();
    });

    _updateModal.onResult(function () {
        _dataTable.ajax.reload();
    });




});
