/*
	Generated by KBEngine!
	Please do not modify this file!
	Please inherit this module, such as: (class Halls : public HallsBase)
	tools = kbcmd
*/

#pragma once
#include "KBECommon.h"
#include "Entity.h"
#include "KBETypes.h"
#include "EntityCallHallsBase.h"

class Method;
class Property;
class MemoryStream;

// defined in */scripts/entity_defs/Halls.def
	// Please inherit and implement "class Halls : public HallsBase"
class KBENGINEPLUGINS_API HallsBase : public Entity
{
public:
	EntityBaseEntityCall_HallsBase* pBaseEntityCall;
	EntityCellEntityCall_HallsBase* pCellEntityCall;



	void onGetBase() override;
	void onGetCell() override;
	void onLoseCell() override;

	EntityCall* getBaseEntityCall() override;
	EntityCall* getCellEntityCall() override;


	void onRemoteMethodCall(MemoryStream& stream) override;
	void onUpdatePropertys(MemoryStream& stream) override;
	void callPropertysSetMethods() override;

	HallsBase();
	virtual ~HallsBase();

	void attachComponents() override;
	void detachComponents() override;

};

