﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class DG_Tweening_DOTweenVisualManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(DG.Tweening.DOTweenVisualManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("preset", get_preset, set_preset);
		L.RegVar("onEnableBehaviour", get_onEnableBehaviour, set_onEnableBehaviour);
		L.RegVar("onDisableBehaviour", get_onDisableBehaviour, set_onDisableBehaviour);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_preset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.DOTweenVisualManager obj = (DG.Tweening.DOTweenVisualManager)o;
			DG.Tweening.Core.VisualManagerPreset ret = obj.preset;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index preset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onEnableBehaviour(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.DOTweenVisualManager obj = (DG.Tweening.DOTweenVisualManager)o;
			DG.Tweening.Core.OnEnableBehaviour ret = obj.onEnableBehaviour;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEnableBehaviour on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDisableBehaviour(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.DOTweenVisualManager obj = (DG.Tweening.DOTweenVisualManager)o;
			DG.Tweening.Core.OnDisableBehaviour ret = obj.onDisableBehaviour;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDisableBehaviour on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_preset(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.DOTweenVisualManager obj = (DG.Tweening.DOTweenVisualManager)o;
			DG.Tweening.Core.VisualManagerPreset arg0 = (DG.Tweening.Core.VisualManagerPreset)ToLua.CheckObject(L, 2, typeof(DG.Tweening.Core.VisualManagerPreset));
			obj.preset = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index preset on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onEnableBehaviour(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.DOTweenVisualManager obj = (DG.Tweening.DOTweenVisualManager)o;
			DG.Tweening.Core.OnEnableBehaviour arg0 = (DG.Tweening.Core.OnEnableBehaviour)ToLua.CheckObject(L, 2, typeof(DG.Tweening.Core.OnEnableBehaviour));
			obj.onEnableBehaviour = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onEnableBehaviour on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDisableBehaviour(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			DG.Tweening.DOTweenVisualManager obj = (DG.Tweening.DOTweenVisualManager)o;
			DG.Tweening.Core.OnDisableBehaviour arg0 = (DG.Tweening.Core.OnDisableBehaviour)ToLua.CheckObject(L, 2, typeof(DG.Tweening.Core.OnDisableBehaviour));
			obj.onDisableBehaviour = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index onDisableBehaviour on a nil value");
		}
	}
}

