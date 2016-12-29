/*
后期部署脚本模板							
--------------------------------------------------------------------------------------
 此文件包含将附加到生成脚本中的 SQL 语句。		
 使用 SQLCMD 语法将文件包含到后期部署脚本中。			
 示例:      :r .\myfile.sql								
 使用 SQLCMD 语法引用后期部署脚本中的变量。		
 示例:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

--insert into T_Device_Type 
--(F_Id,F_Code,F_Category_Name,F_HeadIcon,F_SortCode,F_DeleteMark,
--F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,
--F_LastModifyUserId,F_DeleteTime,F_DeleteUserId)
--values('1','0','摄像头','0',1,'0','0','暂无',getdate(),'0',getdate(),
--'0',null,'0')

--insert into T_Device_Type 
--(F_Id,F_Code,F_Category_Name,F_HeadIcon,F_SortCode,F_DeleteMark,
--F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,
--F_LastModifyUserId,F_DeleteTime,F_DeleteUserId)
--values('2','0','水体检测仪','0',1,'0','0','暂无',getdate(),'0',getdate(),
--'0',null,'0')

--insert into T_Device_Type 
--(F_Id,F_Code,F_Category_Name,F_HeadIcon,F_SortCode,F_DeleteMark,
--F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,
--F_LastModifyUserId,F_DeleteTime,F_DeleteUserId)
--values('3','0','投料机开关','0',1,'0','0','暂无',getdate(),'0',getdate(),
--'0',null,'0')

--insert into T_Device_Type 
--(F_Id,F_Code,F_Category_Name,F_HeadIcon,F_SortCode,F_DeleteMark,
--F_EnabledMark,F_Description,F_CreatorTime,F_CreatorUserId,F_LastModifyTime,
--F_LastModifyUserId,F_DeleteTime,F_DeleteUserId)
--values('4','0','增氧机开关','0',1,'0','0','暂无',getdate(),'0',getdate(),
--'0',null,'0')