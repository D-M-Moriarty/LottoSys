SELECT COUNT(T.TICKETID) AS Total_Tickets_Sold, 
                SUM(T.Price) AS Total_Income, 
                SUM(PR.PRIZEAMOUNT) AS Payout, 
                SUM(T.Price) - SUM(PR.PRIZEAMOUNT) AS Profit 
                FROM Ticket T LEFT JOIN PRIZES PR ON T.TICKETID = PR.TICKETID 
                WHERE T.PURCHASEDATE >= '01-Jan-17' AND T.PURCHASEDATE <= '01-Apr-17';
                
            
select sum(price) from ticket;

select count(*) from ticket;

SELECT COUNT(*)
FROM Ticket
WHERE PURCHASEDATE >= '01-Jan-17' 
                AND PURCHASEDATE <= '01-Apr-17';
                
                
                SELECT TicketID, COUNT(*)
                FROM Prizes
                GROUP BY TicketID HAVING COUNT(*) > 1;
                