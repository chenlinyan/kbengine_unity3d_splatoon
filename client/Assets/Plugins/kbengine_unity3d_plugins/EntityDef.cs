/*
	Generated by KBEngine!
	Please do not modify this file!
	tools = kbcmd
*/

namespace KBEngine
{
	using UnityEngine;
	using System;
	using System.Collections;
	using System.Collections.Generic;

	public class EntityDef
	{
		public static Dictionary<string, UInt16> datatype2id = new Dictionary<string, UInt16>();
		public static Dictionary<string, DATATYPE_BASE> datatypes = new Dictionary<string, DATATYPE_BASE>();
		public static Dictionary<UInt16, DATATYPE_BASE> id2datatypes = new Dictionary<UInt16, DATATYPE_BASE>();
		public static Dictionary<string, Int32> entityclass = new Dictionary<string, Int32>();
		public static Dictionary<string, ScriptModule> moduledefs = new Dictionary<string, ScriptModule>();
		public static Dictionary<UInt16, ScriptModule> idmoduledefs = new Dictionary<UInt16, ScriptModule>();

		public static bool init()
		{
			initDataTypes();
			initDefTypes();
			initScriptModules();
			return true;
		}

		public static bool reset()
		{
			clear();
			return init();
		}

		public static void clear()
		{
			datatype2id.Clear();
			datatypes.Clear();
			id2datatypes.Clear();
			entityclass.Clear();
			moduledefs.Clear();
			idmoduledefs.Clear();
		}

		public static void initDataTypes()
		{
			datatypes["UINT8"] = new DATATYPE_UINT8();
			datatypes["UINT16"] = new DATATYPE_UINT16();
			datatypes["UINT32"] = new DATATYPE_UINT32();
			datatypes["UINT64"] = new DATATYPE_UINT64();

			datatypes["INT8"] = new DATATYPE_INT8();
			datatypes["INT16"] = new DATATYPE_INT16();
			datatypes["INT32"] = new DATATYPE_INT32();
			datatypes["INT64"] = new DATATYPE_INT64();

			datatypes["FLOAT"] = new DATATYPE_FLOAT();
			datatypes["DOUBLE"] = new DATATYPE_DOUBLE();

			datatypes["STRING"] = new DATATYPE_STRING();
			datatypes["VECTOR2"] = new DATATYPE_VECTOR2();

			datatypes["VECTOR3"] = new DATATYPE_VECTOR3();

			datatypes["VECTOR4"] = new DATATYPE_VECTOR4();
			datatypes["PYTHON"] = new DATATYPE_PYTHON();

			datatypes["UNICODE"] = new DATATYPE_UNICODE();
			datatypes["ENTITYCALL"] = new DATATYPE_ENTITYCALL();

			datatypes["BLOB"] = new DATATYPE_BLOB();
		}

		public static void initScriptModules()
		{
			ScriptModule pAvatarModule = new ScriptModule("Avatar");
			EntityDef.moduledefs["Avatar"] = pAvatarModule;
			EntityDef.idmoduledefs[1] = pAvatarModule;

			Property pAvatar_position = new Property();
			pAvatar_position.name = "position";
			pAvatar_position.properUtype = 40000;
			pAvatar_position.properFlags = 4;
			pAvatar_position.aliasID = 1;
			Vector3 Avatar_position_defval = new Vector3();
			pAvatar_position.defaultVal = Avatar_position_defval;
			pAvatarModule.propertys["position"] = pAvatar_position; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_position.aliasID] = pAvatar_position;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(position / 40000).");

			Property pAvatar_direction = new Property();
			pAvatar_direction.name = "direction";
			pAvatar_direction.properUtype = 40001;
			pAvatar_direction.properFlags = 4;
			pAvatar_direction.aliasID = 2;
			Vector3 Avatar_direction_defval = new Vector3();
			pAvatar_direction.defaultVal = Avatar_direction_defval;
			pAvatarModule.propertys["direction"] = pAvatar_direction; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_direction.aliasID] = pAvatar_direction;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(direction / 40001).");

			Property pAvatar_spaceID = new Property();
			pAvatar_spaceID.name = "spaceID";
			pAvatar_spaceID.properUtype = 40002;
			pAvatar_spaceID.properFlags = 16;
			pAvatar_spaceID.aliasID = 3;
			UInt32 Avatar_spaceID_defval;
			UInt32.TryParse("", out Avatar_spaceID_defval);
			pAvatar_spaceID.defaultVal = Avatar_spaceID_defval;
			pAvatarModule.propertys["spaceID"] = pAvatar_spaceID; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_spaceID.aliasID] = pAvatar_spaceID;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(spaceID / 40002).");

			Property pAvatar_componentFrameSync = new Property();
			pAvatar_componentFrameSync.name = "componentFrameSync";
			pAvatar_componentFrameSync.properUtype = 15;
			pAvatar_componentFrameSync.properFlags = 157;
			pAvatar_componentFrameSync.aliasID = 4;
			pAvatarModule.propertys["componentFrameSync"] = pAvatar_componentFrameSync; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_componentFrameSync.aliasID] = pAvatar_componentFrameSync;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(componentFrameSync / 15).");

			Property pAvatar_gameStateC = new Property();
			pAvatar_gameStateC.name = "gameStateC";
			pAvatar_gameStateC.properUtype = 11;
			pAvatar_gameStateC.properFlags = 4;
			pAvatar_gameStateC.aliasID = 5;
			SByte Avatar_gameStateC_defval;
			SByte.TryParse("0", out Avatar_gameStateC_defval);
			pAvatar_gameStateC.defaultVal = Avatar_gameStateC_defval;
			pAvatarModule.propertys["gameStateC"] = pAvatar_gameStateC; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_gameStateC.aliasID] = pAvatar_gameStateC;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(gameStateC / 11).");

			Property pAvatar_modelID = new Property();
			pAvatar_modelID.name = "modelID";
			pAvatar_modelID.properUtype = 13;
			pAvatar_modelID.properFlags = 4;
			pAvatar_modelID.aliasID = 6;
			Byte Avatar_modelID_defval;
			Byte.TryParse("0", out Avatar_modelID_defval);
			pAvatar_modelID.defaultVal = Avatar_modelID_defval;
			pAvatarModule.propertys["modelID"] = pAvatar_modelID; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_modelID.aliasID] = pAvatar_modelID;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(modelID / 13).");

			Property pAvatar_moveSpeed = new Property();
			pAvatar_moveSpeed.name = "moveSpeed";
			pAvatar_moveSpeed.properUtype = 8;
			pAvatar_moveSpeed.properFlags = 4;
			pAvatar_moveSpeed.aliasID = 7;
			float Avatar_moveSpeed_defval;
			float.TryParse("6.5", out Avatar_moveSpeed_defval);
			pAvatar_moveSpeed.defaultVal = Avatar_moveSpeed_defval;
			pAvatarModule.propertys["moveSpeed"] = pAvatar_moveSpeed; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_moveSpeed.aliasID] = pAvatar_moveSpeed;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(moveSpeed / 8).");

			Property pAvatar_name = new Property();
			pAvatar_name.name = "name";
			pAvatar_name.properUtype = 3;
			pAvatar_name.properFlags = 4;
			pAvatar_name.aliasID = 8;
			string Avatar_name_defval = "";
			pAvatar_name.defaultVal = Avatar_name_defval;
			pAvatarModule.propertys["name"] = pAvatar_name; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_name.aliasID] = pAvatar_name;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(name / 3).");

			Property pAvatar_roleType = new Property();
			pAvatar_roleType.name = "roleType";
			pAvatar_roleType.properUtype = 4;
			pAvatar_roleType.properFlags = 4;
			pAvatar_roleType.aliasID = 9;
			Byte Avatar_roleType_defval;
			Byte.TryParse("0", out Avatar_roleType_defval);
			pAvatar_roleType.defaultVal = Avatar_roleType_defval;
			pAvatarModule.propertys["roleType"] = pAvatar_roleType; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_roleType.aliasID] = pAvatar_roleType;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(roleType / 4).");

			Property pAvatar_state = new Property();
			pAvatar_state.name = "state";
			pAvatar_state.properUtype = 9;
			pAvatar_state.properFlags = 4;
			pAvatar_state.aliasID = 10;
			SByte Avatar_state_defval;
			SByte.TryParse("0", out Avatar_state_defval);
			pAvatar_state.defaultVal = Avatar_state_defval;
			pAvatarModule.propertys["state"] = pAvatar_state; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_state.aliasID] = pAvatar_state;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(state / 9).");

			Property pAvatar_teamID = new Property();
			pAvatar_teamID.name = "teamID";
			pAvatar_teamID.properUtype = 6;
			pAvatar_teamID.properFlags = 4;
			pAvatar_teamID.aliasID = 11;
			Byte Avatar_teamID_defval;
			Byte.TryParse("0", out Avatar_teamID_defval);
			pAvatar_teamID.defaultVal = Avatar_teamID_defval;
			pAvatarModule.propertys["teamID"] = pAvatar_teamID; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_teamID.aliasID] = pAvatar_teamID;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(teamID / 6).");

			Property pAvatar_weaponID = new Property();
			pAvatar_weaponID.name = "weaponID";
			pAvatar_weaponID.properUtype = 5;
			pAvatar_weaponID.properFlags = 4;
			pAvatar_weaponID.aliasID = 12;
			Int32 Avatar_weaponID_defval;
			Int32.TryParse("0", out Avatar_weaponID_defval);
			pAvatar_weaponID.defaultVal = Avatar_weaponID_defval;
			pAvatarModule.propertys["weaponID"] = pAvatar_weaponID; 

			pAvatarModule.usePropertyDescrAlias = true;
			pAvatarModule.idpropertys[(UInt16)pAvatar_weaponID.aliasID] = pAvatar_weaponID;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), property(weaponID / 5).");

			List<DATATYPE_BASE> pAvatar_onEnding_args = new List<DATATYPE_BASE>();

			Method pAvatar_onEnding = new Method();
			pAvatar_onEnding.name = "onEnding";
			pAvatar_onEnding.methodUtype = 14;
			pAvatar_onEnding.aliasID = 1;
			pAvatar_onEnding.args = pAvatar_onEnding_args;

			pAvatarModule.methods["onEnding"] = pAvatar_onEnding; 
			pAvatarModule.useMethodDescrAlias = true;
			pAvatarModule.idmethods[(UInt16)pAvatar_onEnding.aliasID] = pAvatar_onEnding;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(onEnding / 14).");

			List<DATATYPE_BASE> pAvatar_onPlayerQuitMatch_args = new List<DATATYPE_BASE>();
			pAvatar_onPlayerQuitMatch_args.Add(EntityDef.id2datatypes[8]);

			Method pAvatar_onPlayerQuitMatch = new Method();
			pAvatar_onPlayerQuitMatch.name = "onPlayerQuitMatch";
			pAvatar_onPlayerQuitMatch.methodUtype = 10;
			pAvatar_onPlayerQuitMatch.aliasID = 2;
			pAvatar_onPlayerQuitMatch.args = pAvatar_onPlayerQuitMatch_args;

			pAvatarModule.methods["onPlayerQuitMatch"] = pAvatar_onPlayerQuitMatch; 
			pAvatarModule.useMethodDescrAlias = true;
			pAvatarModule.idmethods[(UInt16)pAvatar_onPlayerQuitMatch.aliasID] = pAvatar_onPlayerQuitMatch;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(onPlayerQuitMatch / 10).");

			List<DATATYPE_BASE> pAvatar_onReadyForBattle_args = new List<DATATYPE_BASE>();

			Method pAvatar_onReadyForBattle = new Method();
			pAvatar_onReadyForBattle.name = "onReadyForBattle";
			pAvatar_onReadyForBattle.methodUtype = 12;
			pAvatar_onReadyForBattle.aliasID = 3;
			pAvatar_onReadyForBattle.args = pAvatar_onReadyForBattle_args;

			pAvatarModule.methods["onReadyForBattle"] = pAvatar_onReadyForBattle; 
			pAvatarModule.useMethodDescrAlias = true;
			pAvatarModule.idmethods[(UInt16)pAvatar_onReadyForBattle.aliasID] = pAvatar_onReadyForBattle;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(onReadyForBattle / 12).");

			List<DATATYPE_BASE> pAvatar_onResPlayersInfo_args = new List<DATATYPE_BASE>();
			pAvatar_onResPlayersInfo_args.Add(EntityDef.id2datatypes[26]);

			Method pAvatar_onResPlayersInfo = new Method();
			pAvatar_onResPlayersInfo.name = "onResPlayersInfo";
			pAvatar_onResPlayersInfo.methodUtype = 9;
			pAvatar_onResPlayersInfo.aliasID = 4;
			pAvatar_onResPlayersInfo.args = pAvatar_onResPlayersInfo_args;

			pAvatarModule.methods["onResPlayersInfo"] = pAvatar_onResPlayersInfo; 
			pAvatarModule.useMethodDescrAlias = true;
			pAvatarModule.idmethods[(UInt16)pAvatar_onResPlayersInfo.aliasID] = pAvatar_onResPlayersInfo;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(onResPlayersInfo / 9).");

			List<DATATYPE_BASE> pAvatar_onReturnHalls_args = new List<DATATYPE_BASE>();

			Method pAvatar_onReturnHalls = new Method();
			pAvatar_onReturnHalls.name = "onReturnHalls";
			pAvatar_onReturnHalls.methodUtype = 13;
			pAvatar_onReturnHalls.aliasID = 5;
			pAvatar_onReturnHalls.args = pAvatar_onReturnHalls_args;

			pAvatarModule.methods["onReturnHalls"] = pAvatar_onReturnHalls; 
			pAvatarModule.useMethodDescrAlias = true;
			pAvatarModule.idmethods[(UInt16)pAvatar_onReturnHalls.aliasID] = pAvatar_onReturnHalls;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(onReturnHalls / 13).");

			List<DATATYPE_BASE> pAvatar_onStatisticalResult_args = new List<DATATYPE_BASE>();
			pAvatar_onStatisticalResult_args.Add(EntityDef.id2datatypes[2]);
			pAvatar_onStatisticalResult_args.Add(EntityDef.id2datatypes[13]);

			Method pAvatar_onStatisticalResult = new Method();
			pAvatar_onStatisticalResult.name = "onStatisticalResult";
			pAvatar_onStatisticalResult.methodUtype = 15;
			pAvatar_onStatisticalResult.aliasID = 6;
			pAvatar_onStatisticalResult.args = pAvatar_onStatisticalResult_args;

			pAvatarModule.methods["onStatisticalResult"] = pAvatar_onStatisticalResult; 
			pAvatarModule.useMethodDescrAlias = true;
			pAvatarModule.idmethods[(UInt16)pAvatar_onStatisticalResult.aliasID] = pAvatar_onStatisticalResult;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(onStatisticalResult / 15).");

			List<DATATYPE_BASE> pAvatar_onTeamMateChange_args = new List<DATATYPE_BASE>();

			Method pAvatar_onTeamMateChange = new Method();
			pAvatar_onTeamMateChange.name = "onTeamMateChange";
			pAvatar_onTeamMateChange.methodUtype = 11;
			pAvatar_onTeamMateChange.aliasID = 7;
			pAvatar_onTeamMateChange.args = pAvatar_onTeamMateChange_args;

			pAvatarModule.methods["onTeamMateChange"] = pAvatar_onTeamMateChange; 
			pAvatarModule.useMethodDescrAlias = true;
			pAvatarModule.idmethods[(UInt16)pAvatar_onTeamMateChange.aliasID] = pAvatar_onTeamMateChange;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(onTeamMateChange / 11).");

			List<DATATYPE_BASE> pAvatar_endOfStatistics_args = new List<DATATYPE_BASE>();

			Method pAvatar_endOfStatistics = new Method();
			pAvatar_endOfStatistics.name = "endOfStatistics";
			pAvatar_endOfStatistics.methodUtype = 7;
			pAvatar_endOfStatistics.aliasID = -1;
			pAvatar_endOfStatistics.args = pAvatar_endOfStatistics_args;

			pAvatarModule.methods["endOfStatistics"] = pAvatar_endOfStatistics; 
			pAvatarModule.base_methods["endOfStatistics"] = pAvatar_endOfStatistics;

			pAvatarModule.idbase_methods[pAvatar_endOfStatistics.methodUtype] = pAvatar_endOfStatistics;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(endOfStatistics / 7).");

			List<DATATYPE_BASE> pAvatar_enterStartGame_args = new List<DATATYPE_BASE>();

			Method pAvatar_enterStartGame = new Method();
			pAvatar_enterStartGame.name = "enterStartGame";
			pAvatar_enterStartGame.methodUtype = 5;
			pAvatar_enterStartGame.aliasID = -1;
			pAvatar_enterStartGame.args = pAvatar_enterStartGame_args;

			pAvatarModule.methods["enterStartGame"] = pAvatar_enterStartGame; 
			pAvatarModule.base_methods["enterStartGame"] = pAvatar_enterStartGame;

			pAvatarModule.idbase_methods[pAvatar_enterStartGame.methodUtype] = pAvatar_enterStartGame;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(enterStartGame / 5).");

			List<DATATYPE_BASE> pAvatar_registerHalls_args = new List<DATATYPE_BASE>();

			Method pAvatar_registerHalls = new Method();
			pAvatar_registerHalls.name = "registerHalls";
			pAvatar_registerHalls.methodUtype = 4;
			pAvatar_registerHalls.aliasID = -1;
			pAvatar_registerHalls.args = pAvatar_registerHalls_args;

			pAvatarModule.methods["registerHalls"] = pAvatar_registerHalls; 
			pAvatarModule.base_methods["registerHalls"] = pAvatar_registerHalls;

			pAvatarModule.idbase_methods[pAvatar_registerHalls.methodUtype] = pAvatar_registerHalls;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(registerHalls / 4).");

			List<DATATYPE_BASE> pAvatar_statisticalResult_args = new List<DATATYPE_BASE>();
			pAvatar_statisticalResult_args.Add(EntityDef.id2datatypes[2]);
			pAvatar_statisticalResult_args.Add(EntityDef.id2datatypes[13]);

			Method pAvatar_statisticalResult = new Method();
			pAvatar_statisticalResult.name = "statisticalResult";
			pAvatar_statisticalResult.methodUtype = 6;
			pAvatar_statisticalResult.aliasID = -1;
			pAvatar_statisticalResult.args = pAvatar_statisticalResult_args;

			pAvatarModule.methods["statisticalResult"] = pAvatar_statisticalResult; 
			pAvatarModule.base_methods["statisticalResult"] = pAvatar_statisticalResult;

			pAvatarModule.idbase_methods[pAvatar_statisticalResult.methodUtype] = pAvatar_statisticalResult;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(statisticalResult / 6).");

			List<DATATYPE_BASE> pAvatar_weaponChanged_args = new List<DATATYPE_BASE>();
			pAvatar_weaponChanged_args.Add(EntityDef.id2datatypes[8]);

			Method pAvatar_weaponChanged = new Method();
			pAvatar_weaponChanged.name = "weaponChanged";
			pAvatar_weaponChanged.methodUtype = 8;
			pAvatar_weaponChanged.aliasID = -1;
			pAvatar_weaponChanged.args = pAvatar_weaponChanged_args;

			pAvatarModule.methods["weaponChanged"] = pAvatar_weaponChanged; 
			pAvatarModule.base_methods["weaponChanged"] = pAvatar_weaponChanged;

			pAvatarModule.idbase_methods[pAvatar_weaponChanged.methodUtype] = pAvatar_weaponChanged;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Avatar), method(weaponChanged / 8).");

			ScriptModule pFrameSyncReportModule = new ScriptModule("FrameSyncReport");
			EntityDef.moduledefs["FrameSyncReport"] = pFrameSyncReportModule;
			EntityDef.idmoduledefs[2] = pFrameSyncReportModule;

			Property pFrameSyncReport_position = new Property();
			pFrameSyncReport_position.name = "position";
			pFrameSyncReport_position.properUtype = 40000;
			pFrameSyncReport_position.properFlags = 4;
			pFrameSyncReport_position.aliasID = 1;
			Vector3 FrameSyncReport_position_defval = new Vector3();
			pFrameSyncReport_position.defaultVal = FrameSyncReport_position_defval;
			pFrameSyncReportModule.propertys["position"] = pFrameSyncReport_position; 

			pFrameSyncReportModule.usePropertyDescrAlias = true;
			pFrameSyncReportModule.idpropertys[(UInt16)pFrameSyncReport_position.aliasID] = pFrameSyncReport_position;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FrameSyncReport), property(position / 40000).");

			Property pFrameSyncReport_direction = new Property();
			pFrameSyncReport_direction.name = "direction";
			pFrameSyncReport_direction.properUtype = 40001;
			pFrameSyncReport_direction.properFlags = 4;
			pFrameSyncReport_direction.aliasID = 2;
			Vector3 FrameSyncReport_direction_defval = new Vector3();
			pFrameSyncReport_direction.defaultVal = FrameSyncReport_direction_defval;
			pFrameSyncReportModule.propertys["direction"] = pFrameSyncReport_direction; 

			pFrameSyncReportModule.usePropertyDescrAlias = true;
			pFrameSyncReportModule.idpropertys[(UInt16)pFrameSyncReport_direction.aliasID] = pFrameSyncReport_direction;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FrameSyncReport), property(direction / 40001).");

			Property pFrameSyncReport_spaceID = new Property();
			pFrameSyncReport_spaceID.name = "spaceID";
			pFrameSyncReport_spaceID.properUtype = 40002;
			pFrameSyncReport_spaceID.properFlags = 16;
			pFrameSyncReport_spaceID.aliasID = 3;
			UInt32 FrameSyncReport_spaceID_defval;
			UInt32.TryParse("", out FrameSyncReport_spaceID_defval);
			pFrameSyncReport_spaceID.defaultVal = FrameSyncReport_spaceID_defval;
			pFrameSyncReportModule.propertys["spaceID"] = pFrameSyncReport_spaceID; 

			pFrameSyncReportModule.usePropertyDescrAlias = true;
			pFrameSyncReportModule.idpropertys[(UInt16)pFrameSyncReport_spaceID.aliasID] = pFrameSyncReport_spaceID;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FrameSyncReport), property(spaceID / 40002).");

			Property pFrameSyncReport_seatNo = new Property();
			pFrameSyncReport_seatNo.name = "seatNo";
			pFrameSyncReport_seatNo.properUtype = 17;
			pFrameSyncReport_seatNo.properFlags = 16;
			pFrameSyncReport_seatNo.aliasID = 4;
			SByte FrameSyncReport_seatNo_defval;
			SByte.TryParse("0", out FrameSyncReport_seatNo_defval);
			pFrameSyncReport_seatNo.defaultVal = FrameSyncReport_seatNo_defval;
			pFrameSyncReportModule.propertys["seatNo"] = pFrameSyncReport_seatNo; 

			pFrameSyncReportModule.usePropertyDescrAlias = true;
			pFrameSyncReportModule.idpropertys[(UInt16)pFrameSyncReport_seatNo.aliasID] = pFrameSyncReport_seatNo;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FrameSyncReport), property(seatNo / 17).");

			List<DATATYPE_BASE> pFrameSyncReport_onFrameMessage_args = new List<DATATYPE_BASE>();
			pFrameSyncReport_onFrameMessage_args.Add(EntityDef.id2datatypes[29]);

			Method pFrameSyncReport_onFrameMessage = new Method();
			pFrameSyncReport_onFrameMessage.name = "onFrameMessage";
			pFrameSyncReport_onFrameMessage.methodUtype = 18;
			pFrameSyncReport_onFrameMessage.aliasID = 1;
			pFrameSyncReport_onFrameMessage.args = pFrameSyncReport_onFrameMessage_args;

			pFrameSyncReportModule.methods["onFrameMessage"] = pFrameSyncReport_onFrameMessage; 
			pFrameSyncReportModule.useMethodDescrAlias = true;
			pFrameSyncReportModule.idmethods[(UInt16)pFrameSyncReport_onFrameMessage.aliasID] = pFrameSyncReport_onFrameMessage;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FrameSyncReport), method(onFrameMessage / 18).");

			List<DATATYPE_BASE> pFrameSyncReport_reportFrame_args = new List<DATATYPE_BASE>();
			pFrameSyncReport_reportFrame_args.Add(EntityDef.id2datatypes[28]);

			Method pFrameSyncReport_reportFrame = new Method();
			pFrameSyncReport_reportFrame.name = "reportFrame";
			pFrameSyncReport_reportFrame.methodUtype = 16;
			pFrameSyncReport_reportFrame.aliasID = -1;
			pFrameSyncReport_reportFrame.args = pFrameSyncReport_reportFrame_args;

			pFrameSyncReportModule.methods["reportFrame"] = pFrameSyncReport_reportFrame; 
			pFrameSyncReportModule.cell_methods["reportFrame"] = pFrameSyncReport_reportFrame;

			pFrameSyncReportModule.idcell_methods[pFrameSyncReport_reportFrame.methodUtype] = pFrameSyncReport_reportFrame;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(FrameSyncReport), method(reportFrame / 16).");

			ScriptModule pAccountModule = new ScriptModule("Account");
			EntityDef.moduledefs["Account"] = pAccountModule;
			EntityDef.idmoduledefs[3] = pAccountModule;

			Property pAccount_position = new Property();
			pAccount_position.name = "position";
			pAccount_position.properUtype = 40000;
			pAccount_position.properFlags = 4;
			pAccount_position.aliasID = 1;
			Vector3 Account_position_defval = new Vector3();
			pAccount_position.defaultVal = Account_position_defval;
			pAccountModule.propertys["position"] = pAccount_position; 

			pAccountModule.usePropertyDescrAlias = true;
			pAccountModule.idpropertys[(UInt16)pAccount_position.aliasID] = pAccount_position;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), property(position / 40000).");

			Property pAccount_direction = new Property();
			pAccount_direction.name = "direction";
			pAccount_direction.properUtype = 40001;
			pAccount_direction.properFlags = 4;
			pAccount_direction.aliasID = 2;
			Vector3 Account_direction_defval = new Vector3();
			pAccount_direction.defaultVal = Account_direction_defval;
			pAccountModule.propertys["direction"] = pAccount_direction; 

			pAccountModule.usePropertyDescrAlias = true;
			pAccountModule.idpropertys[(UInt16)pAccount_direction.aliasID] = pAccount_direction;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), property(direction / 40001).");

			Property pAccount_spaceID = new Property();
			pAccount_spaceID.name = "spaceID";
			pAccount_spaceID.properUtype = 40002;
			pAccount_spaceID.properFlags = 16;
			pAccount_spaceID.aliasID = 3;
			UInt32 Account_spaceID_defval;
			UInt32.TryParse("", out Account_spaceID_defval);
			pAccount_spaceID.defaultVal = Account_spaceID_defval;
			pAccountModule.propertys["spaceID"] = pAccount_spaceID; 

			pAccountModule.usePropertyDescrAlias = true;
			pAccountModule.idpropertys[(UInt16)pAccount_spaceID.aliasID] = pAccount_spaceID;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), property(spaceID / 40002).");

			List<DATATYPE_BASE> pAccount_onCreateAvatarResult_args = new List<DATATYPE_BASE>();
			pAccount_onCreateAvatarResult_args.Add(EntityDef.id2datatypes[22]);

			Method pAccount_onCreateAvatarResult = new Method();
			pAccount_onCreateAvatarResult.name = "onCreateAvatarResult";
			pAccount_onCreateAvatarResult.methodUtype = 24;
			pAccount_onCreateAvatarResult.aliasID = 1;
			pAccount_onCreateAvatarResult.args = pAccount_onCreateAvatarResult_args;

			pAccountModule.methods["onCreateAvatarResult"] = pAccount_onCreateAvatarResult; 
			pAccountModule.useMethodDescrAlias = true;
			pAccountModule.idmethods[(UInt16)pAccount_onCreateAvatarResult.aliasID] = pAccount_onCreateAvatarResult;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(onCreateAvatarResult / 24).");

			List<DATATYPE_BASE> pAccount_onReqAvatarList_args = new List<DATATYPE_BASE>();
			pAccount_onReqAvatarList_args.Add(EntityDef.id2datatypes[23]);

			Method pAccount_onReqAvatarList = new Method();
			pAccount_onReqAvatarList.name = "onReqAvatarList";
			pAccount_onReqAvatarList.methodUtype = 23;
			pAccount_onReqAvatarList.aliasID = 2;
			pAccount_onReqAvatarList.args = pAccount_onReqAvatarList_args;

			pAccountModule.methods["onReqAvatarList"] = pAccount_onReqAvatarList; 
			pAccountModule.useMethodDescrAlias = true;
			pAccountModule.idmethods[(UInt16)pAccount_onReqAvatarList.aliasID] = pAccount_onReqAvatarList;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(onReqAvatarList / 23).");

			List<DATATYPE_BASE> pAccount_enterGameRoom_args = new List<DATATYPE_BASE>();
			pAccount_enterGameRoom_args.Add(EntityDef.id2datatypes[5]);

			Method pAccount_enterGameRoom = new Method();
			pAccount_enterGameRoom.name = "enterGameRoom";
			pAccount_enterGameRoom.methodUtype = 21;
			pAccount_enterGameRoom.aliasID = -1;
			pAccount_enterGameRoom.args = pAccount_enterGameRoom_args;

			pAccountModule.methods["enterGameRoom"] = pAccount_enterGameRoom; 
			pAccountModule.base_methods["enterGameRoom"] = pAccount_enterGameRoom;

			pAccountModule.idbase_methods[pAccount_enterGameRoom.methodUtype] = pAccount_enterGameRoom;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(enterGameRoom / 21).");

			List<DATATYPE_BASE> pAccount_reqAvatarList_args = new List<DATATYPE_BASE>();

			Method pAccount_reqAvatarList = new Method();
			pAccount_reqAvatarList.name = "reqAvatarList";
			pAccount_reqAvatarList.methodUtype = 19;
			pAccount_reqAvatarList.aliasID = -1;
			pAccount_reqAvatarList.args = pAccount_reqAvatarList_args;

			pAccountModule.methods["reqAvatarList"] = pAccount_reqAvatarList; 
			pAccountModule.base_methods["reqAvatarList"] = pAccount_reqAvatarList;

			pAccountModule.idbase_methods[pAccount_reqAvatarList.methodUtype] = pAccount_reqAvatarList;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(reqAvatarList / 19).");

			List<DATATYPE_BASE> pAccount_reqCreateAvatar_args = new List<DATATYPE_BASE>();
			pAccount_reqCreateAvatar_args.Add(EntityDef.id2datatypes[2]);
			pAccount_reqCreateAvatar_args.Add(EntityDef.id2datatypes[12]);

			Method pAccount_reqCreateAvatar = new Method();
			pAccount_reqCreateAvatar.name = "reqCreateAvatar";
			pAccount_reqCreateAvatar.methodUtype = 20;
			pAccount_reqCreateAvatar.aliasID = -1;
			pAccount_reqCreateAvatar.args = pAccount_reqCreateAvatar_args;

			pAccountModule.methods["reqCreateAvatar"] = pAccount_reqCreateAvatar; 
			pAccountModule.base_methods["reqCreateAvatar"] = pAccount_reqCreateAvatar;

			pAccountModule.idbase_methods[pAccount_reqCreateAvatar.methodUtype] = pAccount_reqCreateAvatar;

			//Dbg.DEBUG_MSG("EntityDef::initScriptModules: add(Account), method(reqCreateAvatar / 20).");

		}

		public static void initDefTypes()
		{
			{
				UInt16 utype = 2;
				string typeName = "CMD_TYPE";
				string name = "UINT8";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 3;
				string typeName = "UINT16";
				string name = "UINT16";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 5;
				string typeName = "SPACE_KEY";
				string name = "UINT64";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 4;
				string typeName = "FRAMEID";
				string name = "UINT32";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 6;
				string typeName = "INT8";
				string name = "INT8";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 7;
				string typeName = "INT16";
				string name = "INT16";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 8;
				string typeName = "ROOMSTATE";
				string name = "INT32";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 9;
				string typeName = "INT64";
				string name = "INT64";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 1;
				string typeName = "STRING";
				string name = "STRING";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 12;
				string typeName = "NAME";
				string name = "UNICODE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 13;
				string typeName = "FLOAT";
				string name = "FLOAT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 14;
				string typeName = "DOUBLE";
				string name = "DOUBLE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PYTHON";
				string name = "PYTHON";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_DICT";
				string name = "PY_DICT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_TUPLE";
				string name = "PY_TUPLE";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 10;
				string typeName = "PY_LIST";
				string name = "PY_LIST";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 20;
				string typeName = "ENTITYCALL";
				string name = "ENTITYCALL";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 11;
				string typeName = "BLOB";
				string name = "BLOB";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 15;
				string typeName = "VECTOR2";
				string name = "VECTOR2";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 16;
				string typeName = "DIRECTION3D";
				string name = "VECTOR3";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 17;
				string typeName = "VECTOR4";
				string name = "VECTOR4";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 22;
				string typeName = "AVATAR_INFOS";
				DATATYPE_AVATAR_INFOS datatype = new DATATYPE_AVATAR_INFOS();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 23;
				string typeName = "AVATAR_INFOS_LIST";
				DATATYPE_AVATAR_INFOS_LIST datatype = new DATATYPE_AVATAR_INFOS_LIST();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 25;
				string typeName = "MATCHING_INFOS";
				DATATYPE_MATCHING_INFOS datatype = new DATATYPE_MATCHING_INFOS();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 26;
				string typeName = "MATCHING_INFOS_LIST";
				DATATYPE_MATCHING_INFOS_LIST datatype = new DATATYPE_MATCHING_INFOS_LIST();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 28;
				string typeName = "FS_ENTITY_DATA";
				DATATYPE_FS_ENTITY_DATA datatype = new DATATYPE_FS_ENTITY_DATA();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 29;
				string typeName = "FS_FRAME_DATA";
				DATATYPE_FS_FRAME_DATA datatype = new DATATYPE_FS_FRAME_DATA();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 31;
				string typeName = "FS_FRAME_LIST";
				DATATYPE_FS_FRAME_LIST datatype = new DATATYPE_FS_FRAME_LIST();
				EntityDef.datatypes[typeName] = datatype;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 33;
				string typeName = "AnonymousArray_33";
				string name = "ENTITY_COMPONENT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			{
				UInt16 utype = 34;
				string typeName = "AnonymousArray_34";
				string name = "ENTITY_COMPONENT";
				DATATYPE_BASE val = null;
				EntityDef.datatypes.TryGetValue(name, out val);
				EntityDef.datatypes[typeName] = val;
				EntityDef.id2datatypes[utype] = EntityDef.datatypes[typeName];
				EntityDef.datatype2id[typeName] = utype;
			}

			foreach(string datatypeStr in EntityDef.datatypes.Keys)
			{
				DATATYPE_BASE dataType = EntityDef.datatypes[datatypeStr];
				if(dataType != null)
				{
					dataType.bind();
				}
			}
		}

	}


}