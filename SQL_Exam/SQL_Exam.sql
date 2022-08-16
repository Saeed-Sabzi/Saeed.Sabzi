USE [SOCCER_DB]
GO
--1
select [match_no] from [match_mast]
where stop2_sec = 
(
	select Max(stop2_sec) from match_mast
)
--2
select Max(stop2_sec) 'Extra Time(Sec)' from match_mast

--3
select [player_name] from player_mast
where [posi_to_play] = 'GK' and [playing_club] = 'Lazio'
select count(*) 'Total players number' from player_mast where playing_club = 'Lazio' and posi_to_play = 'GK'
--4
create Proc usp_Player
	@Player_ID int
as
begin
	
	if 
	exists(select * from [match_mast] where [plr_of_match] = @Player_ID)
	
		select [match_no], [player_name] 
		from [match_mast]
		inner join[player_mast] on [plr_of_match] = [player_id]
		where [plr_of_match] = @Player_ID
	
	else
		print N'بازیکن مورد نظر هیچ وقت بازیکن برتر نشده است'
	
end

exec [usp_Player] @Player_ID = 160244
--5
select distinct [player_name] , [playing_club] ,[country_name]
from [match_captain] 
inner join [player_mast] on [player_captain] = [player_id]
inner join [Soccer Country] on [player_mast].[team_id] =[country_id] 
where [posi_to_play] = 'GK'

--6
select [match_no], [country_name] from [match_details]
inner join[Soccer Country] on [team_id] = [country_id]
where [decided_by] = 'P'

--7
select [country_name]
from [match_details]
inner join [Soccer Country] on [team_id] = [country_id]
where [decided_by] = 'P' and [win_lose] = 'W'

--8
select [country_name] , [player_name]
from [match_details]
inner join [Soccer Country] on [team_id] = [country_id]
inner join [player_mast] on [player_gk] = [player_id]
where [decided_by] = 'P'

--9
select [country_name] , [match_no]
from [player_in_out]
inner join [Soccer Country] on [team_id] = [country_id]
where [time_in_out] < 80
group by [match_no] , [country_name] having count(*) = 6
order by [match_no],[country_name]

--10
create Proc usp_Search
	@Ass_ref_ID int
as
begin
	
  	select substring([ass_ref_name], charindex(' ', [ass_ref_name]) + 1 , len([ass_ref_name]))
	from [asst_referee_mast]
	where [ass_ref_id] = @Ass_ref_ID

end

exec [usp_Search] @Ass_ref_ID = 80003







