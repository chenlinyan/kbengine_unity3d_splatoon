/*
	Generated by KBEngine!
	Please do not modify this file!
	
	tools = kbcmd
*/

#pragma once

#include "KBECommon.h"
#include "EntityCall.h"
#include "KBETypes.h"
#include "CustomDataTypes.h"


// defined in */scripts/entity_defs/FrameSyncMgr.def

class KBENGINEPLUGINS_API EntityBaseEntityCall_FrameSyncMgrBase : public EntityCall
{
public:

	EntityBaseEntityCall_FrameSyncMgrBase(int32 eid, const FString& ename);

	virtual ~EntityBaseEntityCall_FrameSyncMgrBase();
};

class KBENGINEPLUGINS_API EntityCellEntityCall_FrameSyncMgrBase : public EntityCall
{
public:

	EntityCellEntityCall_FrameSyncMgrBase(int32 eid, const FString& ename);

	virtual ~EntityCellEntityCall_FrameSyncMgrBase();
};