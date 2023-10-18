﻿using MediatR;

namespace Ordering.Application.Features.Orders.DeleteOrder;

public class DeleteOrderCommand: IRequest<Unit>
{
    public int Id {get; set;}
}