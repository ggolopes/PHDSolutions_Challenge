--select pr.purchaser, pr.PONumber, pr.partNumber
--from PurchaseRecord pr Join Users u ON u.userName = pr.purchaser 
--where pr.projet = '1036'
--order by pr.PONumber;

---- Usuarios que fizeram compras em um projeto (contabilizado o quantitativo de compras por usuario
--select distinct u.fullName AS Purchaser_Fullname, count(pr.partNumber) AS Number_of_Purchases
--from Users u Join PurchaseRecord pr ON u.userName = pr.purchaser 
--where pr.projet = '1036'
--group by u.fullName;

---- Usuarios que fizeram compras em um projeto (contabilizado o quantitativo de compras por usuario
--select distinct u.fullName AS Purchaser_Fullname, count(pr.partNumber) AS Number_of_Purchases
--from Users u Join PurchaseRecord pr ON u.userName = pr.purchaser 
--where pr.projet = '1036'
--group by u.fullName;

---- Todas as partes compradas em um projeto custo e quantidade
--select pr.partNumber, mm.Description, sum(pr.quantity) AS Quantity_Total, ROUND(sum((pr.costPer*pr.quantity)),2) as Cost_Total
--		from PurchaseRecord pr JOIN MaterialMaster mm ON pr.partNumber = mm.PartNumber
--		where pr.projet = '1036'
--		group by pr.partNumber, mm.Description
--		order by pr.partNumber

-- Custo total em um projeto
--select pr.projet AS Proj_Number, pj.ProjectDescription AS Project_Name, ROUND(sum((pr.costPer*pr.quantity)),2) as Project_Cost_Total
--		from PurchaseRecord pr
--		JOIN ProjectRecord pj ON pj.projectNumber = pr.projet
--		where pr.projet = '1036'
--		group by pr.projet, pj.projectDescription

