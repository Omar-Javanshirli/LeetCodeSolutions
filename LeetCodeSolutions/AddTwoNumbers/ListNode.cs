namespace LeetCodeSolutions.AddTwoNumbers
{
    public class ListNode
    {
        public int Data { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int data = 0, ListNode next = null)
        {
            this.Data = data;
            this.Next = next;
        }

        public void PushFront(ref ListNode head, int newData)
        {
            ListNode newNode = new ListNode()
            {
                Data = newData,
                Next = head
            };

            head = newNode;
        }
    }
}
