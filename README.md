Create a class library project named CafeBoston.DATA and create 5 classes and 1 enum as described below.

Product
* Product Name: string
* UnitPrice: decimal
- ToString(): string

OrderDetail
* ProductName: string
* UnitPrice: decimal
* Quantity: int
* TotalPriceTRY: string-readonly
- TotalPrice(): decimal

OrderState (Active = 0, Paid = 1, Canceled = 2)

Order
* TableNo: int
* State: OrderState
* PaidAmount: decimal
* StartTime: DateTime?
* EndTime: DateTime?
* OrderDetails: List<OrderDetail>
* TotalPriceYTL: string-readonly
- TotalPrice(): decimal

CafeData
* TableCount: int
* Product: List<Product>
* ActiveOrders: List<Order>
* PastOrders: List<Order>

