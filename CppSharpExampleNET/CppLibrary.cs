// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

#pragma warning disable CS0109 // Member does not hide an inherited member; new keyword is not required

namespace CppLibrary
{
    public unsafe partial class Example : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 4)]
        public partial struct __Internal
        {
            internal int value;

            [SuppressUnmanagedCodeSecurity, DllImport("CppLibrary", EntryPoint = "??0Example@@QEAA@H@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ctor(__IntPtr __instance, int value);

            [SuppressUnmanagedCodeSecurity, DllImport("CppLibrary", EntryPoint = "??0Example@@QEAA@AEBV0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("CppLibrary", EntryPoint = "?Add@Example@@QEAA?AV1@V1@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void Add(__IntPtr __instance, __IntPtr @return, global::CppLibrary.Example.__Internal other);

            [SuppressUnmanagedCodeSecurity, DllImport("CppLibrary", EntryPoint = "?GetValue@Example@@QEAAHXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern int GetValue(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CppLibrary.Example> NativeToManagedMap =
            new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CppLibrary.Example>();

        internal static void __RecordNativeToManagedMapping(IntPtr native, global::CppLibrary.Example managed)
        {
            NativeToManagedMap[native] = managed;
        }

        internal static bool __TryGetNativeToManagedMapping(IntPtr native, out global::CppLibrary.Example managed)
        {
    
            return NativeToManagedMap.TryGetValue(native, out managed);
        }

        protected bool __ownsNativeInstance;

        internal static Example __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            return new Example(native.ToPointer(), skipVTables);
        }

        internal static Example __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (__TryGetNativeToManagedMapping(native, out var managed))
                return (Example)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                __RecordNativeToManagedMapping(native, result);
            return result;
        }

        internal static Example __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Example(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Example(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
        }

        protected Example(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public Example(int value)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CppLibrary.Example.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
            __Internal.ctor(__Instance, value);
        }

        public Example(global::CppLibrary.Example _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CppLibrary.Example.__Internal));
            __ownsNativeInstance = true;
            __RecordNativeToManagedMapping(__Instance, this);
            *((global::CppLibrary.Example.__Internal*) __Instance) = *((global::CppLibrary.Example.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true, callNativeDtor : __ownsNativeInstance );
        }

        partial void DisposePartial(bool disposing);

        internal protected virtual void Dispose(bool disposing, bool callNativeDtor )
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            DisposePartial(disposing);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::CppLibrary.Example Add(global::CppLibrary.Example other)
        {
            if (ReferenceEquals(other, null))
                throw new global::System.ArgumentNullException("other", "Cannot be null because it is passed by value.");
            var __arg0 = other.__Instance;
            var ___ret = new global::CppLibrary.Example.__Internal();
            __Internal.Add(__Instance, new IntPtr(&___ret), *(global::CppLibrary.Example.__Internal*) __arg0);
            return global::CppLibrary.Example.__CreateInstance(___ret);
        }

        public static implicit operator global::CppLibrary.Example(int value)
        {
            return new global::CppLibrary.Example(value);
        }

        public int Value
        {
            get
            {
                var ___ret = __Internal.GetValue(__Instance);
                return ___ret;
            }
        }
    }
}