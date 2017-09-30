
public class AddTwoNumbersSolution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        int tempVal = l1.val + l2.val;
        int currentVal = -1;

        if (minusTen(tempVal, out currentVal))
        {
            if (l1.next != null && l2.next == null)
            {
                l1.next.val += 1;
                l2.next = new ListNode(0);
            }
            else if (l1.next == null && l2.next != null)
            {
                l1.next = new ListNode(0);
                l2.next.val += 1;
            }
            else if (l1.next == null && l2.next == null)
            {
                l1.next = new ListNode(1);
                l2.next = new ListNode(0);
            }
            else
            {
                l1.next.val += 1;
            }
        }
        else
        {
            currentVal = tempVal;
            if (l1.next != null && l2.next == null)
            {
                l2.next = new ListNode(0);
            }
            else if (l1.next == null && l2.next != null)
            {
                l1.next = new ListNode(0);
            }
        }

        ListNode _result = new ListNode(currentVal);

        if (l1.next != null && l2.next != null)
        {
            _result.next = AddTwoNumbers(l1.next, l2.next);
        }

        return _result;
    }

    bool minusTen(int val, out int finalVal)
    {
        if (val - 10 > -1)
        {
            finalVal = val - 10;
            return true;
        }
        else
        {
            finalVal = -1;
            return false;
        }
    }

}