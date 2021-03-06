﻿using System.ServiceModel;
using mba_model;
using System.Collections.ObjectModel;

namespace mba_services.ServiceContracts
{
    [ServiceContract]
    public interface IImportService
    {
        [OperationContract]
        GoodColumn GoodColumn(string columnHeader);

        [OperationContract]
        GoodColumn[] GoodColumns();

        [OperationContract]
        Client[] Clients();

        [OperationContract]
        ImportType[] ImportTypes();

        [OperationContract]
        ColumnHeader[] AddColumnHeaders(string[] columnHeaders);

        [OperationContract]
        void AddRelationColumnHeadersClient(ObservableCollection<ColumnHeader> columnHeaders, Client client);
    }
}
