$(function () {
    var l = abp.localization.getResource('RemittanceManagement');
    var _createModal = new abp.ModalManager(abp.appPath + 'RemittanceManagement/Create');
    var _updateModal = new abp.ModalManager(abp.appPath + 'RemittanceManagement/Update');



    var _dataTable = $('#RemittancesTable').DataTable(
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
            ajax: abp.libs.datatables.createAjax(remittanceManagement.remittances.remittance.getList),
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
                                    confirmMessage: function (data) { return l('RemittanceDeletionWarningMessage'); },
                                    action: function (data) {
                                        remittanceManagement.remittances.remittance
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
                    title: l('SerialNumber'),
                    data: "serialNumber"
                },
                {
                    title: l('Amount'),
                    data: "amount",
                  
                },
                {
                    title: l('TotalAmount'),
                    data: "totalAmount",
                  
                },
                {
                    title: l('ReceiverFullName'),
                    data: "receiverFullName",

                }, {
                    title: l('CurrencyName'),
                    data: "currencyName",

                }, {
                    title: l('SenderName'),
                    data: "senderName",

                }, {
                    title: l('State'),
                    data: "state",

                }, {
                    title: l('StatusDate'),
                    data: "statusDate",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }
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
    $("#CreateNewRemittanceButtonId").click(function () {
        _createModal.open();
    });

    _createModal.onClose(function () {
        _dataTable.ajax.reload();
    });

    _updateModal.onResult(function () {
        _dataTable.ajax.reload();
    });




});
