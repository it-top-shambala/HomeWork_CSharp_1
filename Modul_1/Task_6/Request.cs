/*              Task_7
 * Описать структуру Request содержащую поля: код заказа; клиент; 
 * дата заказа; перечень заказанных товаров; сумма заказа 
 * (реализовать вычисляемым свойством).

*/

namespace Task_6
{
    public struct Request
    {
        uint Id { get; set; }
        string Client { get; set; }
        DateTime DateTime { get; set; }

    }
}
