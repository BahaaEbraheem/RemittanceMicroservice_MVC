$(function () {
    var l = abp.localization.getResource('CustomerManagement');
    var _createModal = new abp.ModalManager(abp.appPath + 'CustomerManagement/Create');
    var _updateModal = new abp.ModalManager(abp.appPath + 'CustomerManagement/Update');



    var _dataTable = $('#CustomersTable').DataTable(
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
            ajax: abp.libs.datatables.createAjax(customerManagement.customers.customer.getList),
            columnDefs: [
                {
                    rowAction: {
                        items:
                            [
                                {
                                    text: l('Update'),
                                    //visible: abp.auth.isGranted('CustomerManagement.Update'),
                                    action: function (data) {
                                        debugger
                                        _updateModal.open({
                                            id: data.record.id
                                        });
                                    }
                                },
                                {
                                    text: l('Delete'),
                                   // visible: abp.auth.isGranted('CustomerManagement.Delete'),
                                    confirmMessage: function (data) { return l('CustomerDeletionWarningMessage'); },
                                    action: function (data) {
                                        customerManagement.customers.customer
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
                    title: l('FirstName'),
                    data: "firstName"
                },
                {
                    title: l('FatherName'),
                    data: "fatherName",
                  
                },
                {
                    title: l('LastName'),
                    data: "lastName",
                  
                }, {
                    title: l('MotherName'),
                    data: "motherName",

                },
                {
                    title: l('BirthDate'),
                    data: "birthDate",
                    render: function (data) {
                        return luxon
                            .DateTime
                            .fromISO(data, {
                                locale: abp.localization.currentCulture.name
                            }).toLocaleString(luxon.DateTime.DATETIME_SHORT);
                    }

                },
                {
                    title: l('Phone'),
                    data: "phone",

                },
                {
                    title: l('Gender'),
                    data: "gender",
                    render: function (data) {
                        return l('Enum:Gender:' + data);
                    }
                },
                {
                    title: l('Address'),
                    data: "address",

                },
           
                {
                    title: l('CreationTime'),
                    data: "creationTime",
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
    $("#CreateNewCustomerButtonId").click(function () {
        _createModal.open();
    });

    _createModal.onClose(function () {
        _dataTable.ajax.reload();
    });

    _updateModal.onResult(function () {
        _dataTable.ajax.reload();
    });




});
