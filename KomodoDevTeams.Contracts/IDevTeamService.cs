﻿using System.Collections.Generic;
using KomodoDevTeams.Models;

namespace KomodoDevTeams.Contracts
{
    public interface IDevTeamService
    {
        bool CreateDevTeam(DevTeamCreate model);
        bool DeleteDevTeam(int id);
        DevTeamDetails GetDevTeamById(int id);
        IEnumerable<DevTeamListItem> GetDevTeams();
        bool UpdateDevTeam(DevTeamEdit model);
    }
}