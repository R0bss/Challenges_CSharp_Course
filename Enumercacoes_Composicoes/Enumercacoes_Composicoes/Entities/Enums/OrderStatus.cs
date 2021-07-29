using System;
using System.Collections.Generic;
using System.Text;

namespace Enumercacoes_Composicoes.Entities.Enums
{
    class OrderStatus
    {
        enum WorkerLevel : int
        {
            PENDING_PAYMENT = 0,
            PROCESSING = 1,
            SHPPED = 2,
            DELIVERED = 3
        }

    }
}
