// Copyright (c) 2007-2010 SlimDX Group
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

//------------------------------------------------------------------------------
// <auto-generated>
//     Functions for SlimDX2.D3DCompiler namespace.
//     This code was generated by a tool.
//     Date : 11/13/2010 16:58:27
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace SlimDX2.D3DCompiler {


	/// <summary>
    /// D3D Functions.
    /// </summary>
    static partial class D3D {   
        
        /// <summary>	
        /// Compile HLSL code into bytecode for a given target.	
        /// </summary>	
        /// <param name="pSrcData">A pointer to uncompiled shader data; either ASCII HLSL code or a compiled effect.</param>
        /// <param name="srcDataSize">Length of pSrcData.</param>
        /// <param name="sourceNameRef">Optional. The name of the shader file. Use either this or pSrcData.</param>
        /// <param name="definesRef">Optional. An array of NULL-terminated macro definitions (see <see cref="SlimDX2.Direct3D.ShaderMacro"/>).</param>
        /// <param name="includeRef">Optional. A pointer to an <see cref="SlimDX2.D3DCompiler.Include"/> for handling include files. Setting this to NULL will cause a compile error if a shader contains a #include.</param>
        /// <param name="entrypointRef">The name of the shader entry point function.</param>
        /// <param name="targetRef">The shader target or set of shader features to compile against.</param>
        /// <param name="flags1">Shader {{compile options}}.</param>
        /// <param name="flags2">Effect {{compile options}}. When you compile a shader and not an effect file, D3DCompile ignores Flags2; therefore, you can set Flags2 to zero.</param>
        /// <param name="codeRef">The address of a <see cref="SlimDX2.Direct3D.Blob"/> that contains the compiled code.</param>
        /// <param name="errorMsgsRef">Optional. A pointer to an <see cref="SlimDX2.Direct3D.Blob"/> that contains compiler error messages, or NULL if there were no errors.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DCompile([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In, Optional] const char* pSourceName,[In, Buffer, Optional] const D3D_SHADER_MACRO* pDefines,[In, Optional] ID3DInclude* pInclude,[In] const char* pEntrypoint,[In] const char* pTarget,[In] UINT Flags1,[In] UINT Flags2,[Out] ID3DBlob** ppCode,[Out, Optional] ID3DBlob** ppErrorMsgs)</unmanaged>
		public static SlimDX2.Result Compile(IntPtr pSrcData, SlimDX2.Size srcDataSize, string sourceNameRef, SlimDX2.Direct3D.ShaderMacro[] definesRef, IntPtr includeRef, string entrypointRef, string targetRef, SlimDX2.D3DCompiler.ShaderFlags flags1, SlimDX2.D3DCompiler.EffectFlags flags2, out SlimDX2.Direct3D.Blob codeRef, out SlimDX2.Direct3D.Blob errorMsgsRef) {
            unsafe {
                SlimDX2.Direct3D.ShaderMacro.__Native[] definesRef_ = ( definesRef == null)? null : new SlimDX2.Direct3D.ShaderMacro.__Native[definesRef.Length];
                if ( definesRef != null) 
                    for(int i = 0; i < definesRef.Length; i++) {
                   	    definesRef_[i] = new SlimDX2.Direct3D.ShaderMacro.__Native();
                   	    definesRef[i].__MarshalTo(ref definesRef_[i]);					
                    }
                IntPtr codeRef_ = IntPtr.Zero;
                IntPtr errorMsgsRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DCompile_( pSrcData,  srcDataSize,  sourceNameRef,  definesRef_,  includeRef,  entrypointRef,  targetRef,  flags1,  flags2, out codeRef_, out errorMsgsRef_);
                    if ( definesRef != null)
                    for(int i = 0; i < definesRef.Length; i++) {
                       	definesRef_[i].__MarshalFree();
                    }
                codeRef = (codeRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(codeRef_);
                errorMsgsRef = (errorMsgsRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(errorMsgsRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DCompile([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In, Optional] const char* pSourceName,[In, Buffer, Optional] const D3D_SHADER_MACRO* pDefines,[In, Optional] ID3DInclude* pInclude,[In] const char* pEntrypoint,[In] const char* pTarget,[In] UINT Flags1,[In] UINT Flags2,[Out] ID3DBlob** ppCode,[Out, Optional] ID3DBlob** ppErrorMsgs)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DCompile", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DCompile_(IntPtr pSrcData, SlimDX2.Size srcDataSize, [MarshalAs(UnmanagedType.LPStr),In] string sourceNameRef, SlimDX2.Direct3D.ShaderMacro.__Native[] definesRef, IntPtr includeRef, [MarshalAs(UnmanagedType.LPStr),In] string entrypointRef, [MarshalAs(UnmanagedType.LPStr),In] string targetRef, SlimDX2.D3DCompiler.ShaderFlags flags1, SlimDX2.D3DCompiler.EffectFlags flags2, out IntPtr codeRef, out IntPtr errorMsgsRef);		
        
        /// <summary>	
        /// Preprocesses uncompiled HLSL code.	
        /// </summary>	
        /// <remarks>	
        /// D3DPreprocess outputs {{#line}} directives and preserves line numbering of source input so that output line numbering can be properly related to the input source.	
        /// </remarks>	
        /// <param name="pSrcData">A pointer to uncompiled shader data; either ASCII HLSL code or a compiled effect.</param>
        /// <param name="srcDataSize">Length of pSrcData.</param>
        /// <param name="sourceNameRef">Optional. The name of the file that contains the uncompiled HLSL code.</param>
        /// <param name="definesRef">Optional. An array of NULL-terminated macro definitions (see <see cref="SlimDX2.Direct3D.ShaderMacro"/>).</param>
        /// <param name="includeRef">Optional. A pointer to an <see cref="SlimDX2.D3DCompiler.Include"/> for handling include files. Setting this to NULL will cause a compile error if a shader contains a #include.</param>
        /// <param name="codeTextRef">The address of a <see cref="SlimDX2.Direct3D.Blob"/> that contains the compiled code.</param>
        /// <param name="errorMsgsRef">Optional. A pointer to an <see cref="SlimDX2.Direct3D.Blob"/> that contains compiler error messages, or NULL if there were no errors.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DPreprocess([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In, Optional] const char* pSourceName,[In, Buffer, Optional] const D3D_SHADER_MACRO* pDefines,[In, Optional] ID3DInclude* pInclude,[Out] ID3DBlob** ppCodeText,[Out, Optional] ID3DBlob** ppErrorMsgs)</unmanaged>
		public static SlimDX2.Result Preprocess(IntPtr pSrcData, SlimDX2.Size srcDataSize, string sourceNameRef, SlimDX2.Direct3D.ShaderMacro[] definesRef, IntPtr includeRef, out SlimDX2.Direct3D.Blob codeTextRef, out SlimDX2.Direct3D.Blob errorMsgsRef) {
            unsafe {
                SlimDX2.Direct3D.ShaderMacro.__Native[] definesRef_ = ( definesRef == null)? null : new SlimDX2.Direct3D.ShaderMacro.__Native[definesRef.Length];
                if ( definesRef != null) 
                    for(int i = 0; i < definesRef.Length; i++) {
                   	    definesRef_[i] = new SlimDX2.Direct3D.ShaderMacro.__Native();
                   	    definesRef[i].__MarshalTo(ref definesRef_[i]);					
                    }
                IntPtr codeTextRef_ = IntPtr.Zero;
                IntPtr errorMsgsRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DPreprocess_( pSrcData,  srcDataSize,  sourceNameRef,  definesRef_,  includeRef, out codeTextRef_, out errorMsgsRef_);
                    if ( definesRef != null)
                    for(int i = 0; i < definesRef.Length; i++) {
                       	definesRef_[i].__MarshalFree();
                    }
                codeTextRef = (codeTextRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(codeTextRef_);
                errorMsgsRef = (errorMsgsRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(errorMsgsRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DPreprocess([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In, Optional] const char* pSourceName,[In, Buffer, Optional] const D3D_SHADER_MACRO* pDefines,[In, Optional] ID3DInclude* pInclude,[Out] ID3DBlob** ppCodeText,[Out, Optional] ID3DBlob** ppErrorMsgs)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DPreprocess", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DPreprocess_(IntPtr pSrcData, SlimDX2.Size srcDataSize, [MarshalAs(UnmanagedType.LPStr),In] string sourceNameRef, SlimDX2.Direct3D.ShaderMacro.__Native[] definesRef, IntPtr includeRef, out IntPtr codeTextRef, out IntPtr errorMsgsRef);		
        
        /// <summary>	
        /// Gets shader debug information.	
        /// </summary>	
        /// <remarks>	
        /// Debug information is embedded in the body of the shader after calling <see cref="SlimDX2.D3DCompiler.D3D.Compile"/>.	
        /// </remarks>	
        /// <param name="pSrcData">A pointer to source data; either uncompiled or compiled HLSL code.</param>
        /// <param name="srcDataSize">Length of pSrcData.</param>
        /// <param name="debugInfoRef">Optional. A pointer to an <see cref="SlimDX2.Direct3D.Blob"/> that contains debug information.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DGetDebugInfo([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[Out] ID3DBlob** ppDebugInfo)</unmanaged>
		public static SlimDX2.Result GetDebugInfo(IntPtr pSrcData, SlimDX2.Size srcDataSize, out SlimDX2.Direct3D.Blob debugInfoRef) {
            unsafe {
                IntPtr debugInfoRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DGetDebugInfo_( pSrcData,  srcDataSize, out debugInfoRef_);
                debugInfoRef = (debugInfoRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(debugInfoRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DGetDebugInfo([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[Out] ID3DBlob** ppDebugInfo)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DGetDebugInfo", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DGetDebugInfo_(IntPtr pSrcData, SlimDX2.Size srcDataSize, out IntPtr debugInfoRef);		
        
        /// <summary>	
        /// Gets a pointer to a reflection interface.	
        /// </summary>	
        /// <remarks>	
        /// Shader code contains metadata that can be inspected using the reflection APIs.The following code illustrates retrieving a ID3D11ShaderReflection Interface from a shader.	
        /// <code> pd3dDevice-&gt;CreatePixelShader( pPixelShaderBuffer-&gt;GetBufferPointer(), pPixelShaderBuffer-&gt;GetBufferSize(), g_pPSClassLinkage, &amp;g_pPixelShader ); ID3D11ShaderReflection* pReflector = NULL; 	
        /// D3DReflect( pPixelShaderBuffer-&gt;GetBufferPointer(), pPixelShaderBuffer-&gt;GetBufferSize(),  IID_ID3D11ShaderReflection, (void**) &amp;pReflector); </code>	
        /// 	
        /// </remarks>	
        /// <param name="pSrcData">A pointer to source data as compiled HLSL code.</param>
        /// <param name="srcDataSize">Length of pSrcData.</param>
        /// <param name="pInterface">The reference GUID of the COM interface to use. For example, IID_ID3D11ShaderReflection or IID_ID3D10ShaderReflection.</param>
        /// <param name="reflectorRef">A pointer to a reflection interface.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DReflect([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In] REFIID pInterface,[Out] void** ppReflector)</unmanaged>
		public static SlimDX2.Result Reflect(IntPtr pSrcData, SlimDX2.Size srcDataSize, Guid pInterface, out IntPtr reflectorRef) {
            unsafe {
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DReflect_( pSrcData,  srcDataSize, ref  pInterface, out reflectorRef);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DReflect([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In] REFIID pInterface,[Out] void** ppReflector)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DReflect", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DReflect_(IntPtr pSrcData, SlimDX2.Size srcDataSize, ref Guid pInterface, out IntPtr reflectorRef);		
        
        /// <summary>	
        /// Disassembles compiled HLSL code.	
        /// </summary>	
        /// <param name="pSrcData">A pointer to source data as compiled HLSL code.</param>
        /// <param name="srcDataSize">Length of pSrcData.</param>
        /// <param name="flags">Flags affecting the behavior of D3DDisassemble.  Flags can be a combination of zero or more of the following values. FlagDescriptionD3D_DISASM_ENABLE_COLOR_CODEEnable the output of color codes.D3D_DISASM_ENABLE_DEFAULT_VALUE_PRINTSEnable the output of default values.D3D_DISASM_ENABLE_INSTRUCTION_NUMBERINGEnable instruction numbering.D3D_DISASM_ENABLE_INSTRUCTION_CYCLENo effect. </param>
        /// <param name="szComments">Optional.</param>
        /// <param name="disassemblyRef">Optional. A pointer to an <see cref="SlimDX2.Direct3D.Blob"/> that contains assembly text.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DDisassemble([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In] UINT Flags,[In, Optional] const char* szComments,[Out] ID3DBlob** ppDisassembly)</unmanaged>
		public static SlimDX2.Result Disassemble(IntPtr pSrcData, SlimDX2.Size srcDataSize, SlimDX2.D3DCompiler.DisassemblyFlags flags, string szComments, out SlimDX2.Direct3D.Blob disassemblyRef) {
            unsafe {
                IntPtr disassemblyRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DDisassemble_( pSrcData,  srcDataSize,  flags,  szComments, out disassemblyRef_);
                disassemblyRef = (disassemblyRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(disassemblyRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DDisassemble([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In] UINT Flags,[In, Optional] const char* szComments,[Out] ID3DBlob** ppDisassembly)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DDisassemble", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DDisassemble_(IntPtr pSrcData, SlimDX2.Size srcDataSize, SlimDX2.D3DCompiler.DisassemblyFlags flags, [MarshalAs(UnmanagedType.LPStr),In] string szComments, out IntPtr disassemblyRef);		
        
        /// <summary>	
        /// Disassembles compiled HLSL code from a Direct3D10 effect.	
        /// </summary>	
        /// <param name="effectRef">A pointer to source data as compiled HLSL code.</param>
        /// <param name="flags">Shader {{compile options}}.</param>
        /// <param name="disassemblyRef">Optional. A pointer to an <see cref="SlimDX2.Direct3D.Blob"/> that contains disassembly text.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DDisassemble10Effect([In] ID3D10Effect* pEffect,[In] UINT Flags,[Out] ID3DBlob** ppDisassembly)</unmanaged>
		public static SlimDX2.Result Disassemble10Effect(IntPtr effectRef, int flags, out SlimDX2.Direct3D.Blob disassemblyRef) {
            unsafe {
                IntPtr disassemblyRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DDisassemble10Effect_( effectRef,  flags, out disassemblyRef_);
                disassemblyRef = (disassemblyRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(disassemblyRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DDisassemble10Effect([In] ID3D10Effect* pEffect,[In] UINT Flags,[Out] ID3DBlob** ppDisassembly)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DDisassemble10Effect", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DDisassemble10Effect_(IntPtr effectRef, int flags, out IntPtr disassemblyRef);		
        
        /// <summary>	
        /// Gets the input signature from a compilation result.	
        /// </summary>	
        /// <param name="pSrcData">A pointer to source data as compiled HLSL code.</param>
        /// <param name="srcDataSize">Length of pSrcData.</param>
        /// <param name="signatureBlobRef">Optional. A pointer to an <see cref="SlimDX2.Direct3D.Blob"/> that contains a compiled shader.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DGetInputSignatureBlob([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[Out] ID3DBlob** ppSignatureBlob)</unmanaged>
		public static SlimDX2.Result GetInputSignatureBlob(IntPtr pSrcData, SlimDX2.Size srcDataSize, out SlimDX2.Direct3D.Blob signatureBlobRef) {
            unsafe {
                IntPtr signatureBlobRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DGetInputSignatureBlob_( pSrcData,  srcDataSize, out signatureBlobRef_);
                signatureBlobRef = (signatureBlobRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(signatureBlobRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DGetInputSignatureBlob([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[Out] ID3DBlob** ppSignatureBlob)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DGetInputSignatureBlob", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DGetInputSignatureBlob_(IntPtr pSrcData, SlimDX2.Size srcDataSize, out IntPtr signatureBlobRef);		
        
        /// <summary>	
        /// Gets the output signature from a compilation result.	
        /// </summary>	
        /// <param name="pSrcData">A pointer to source data as compiled HLSL code.</param>
        /// <param name="srcDataSize">Length of pSrcData.</param>
        /// <param name="signatureBlobRef">Optional. A pointer to an <see cref="SlimDX2.Direct3D.Blob"/> that contains a compiled shader.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DGetOutputSignatureBlob([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[Out] ID3DBlob** ppSignatureBlob)</unmanaged>
		public static SlimDX2.Result GetOutputSignatureBlob(IntPtr pSrcData, SlimDX2.Size srcDataSize, out SlimDX2.Direct3D.Blob signatureBlobRef) {
            unsafe {
                IntPtr signatureBlobRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DGetOutputSignatureBlob_( pSrcData,  srcDataSize, out signatureBlobRef_);
                signatureBlobRef = (signatureBlobRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(signatureBlobRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DGetOutputSignatureBlob([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[Out] ID3DBlob** ppSignatureBlob)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DGetOutputSignatureBlob", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DGetOutputSignatureBlob_(IntPtr pSrcData, SlimDX2.Size srcDataSize, out IntPtr signatureBlobRef);		
        
        /// <summary>	
        /// Gets the input and output signatures from a compilation result.	
        /// </summary>	
        /// <param name="pSrcData">A pointer to source data as compiled HLSL code.</param>
        /// <param name="srcDataSize">Length of pSrcData.</param>
        /// <param name="signatureBlobRef">Optional. A pointer to an <see cref="SlimDX2.Direct3D.Blob"/> that contains a compiled shader.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DGetInputAndOutputSignatureBlob([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[Out] ID3DBlob** ppSignatureBlob)</unmanaged>
		public static SlimDX2.Result GetInputAndOutputSignatureBlob(IntPtr pSrcData, SlimDX2.Size srcDataSize, out SlimDX2.Direct3D.Blob signatureBlobRef) {
            unsafe {
                IntPtr signatureBlobRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DGetInputAndOutputSignatureBlob_( pSrcData,  srcDataSize, out signatureBlobRef_);
                signatureBlobRef = (signatureBlobRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(signatureBlobRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DGetInputAndOutputSignatureBlob([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[Out] ID3DBlob** ppSignatureBlob)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DGetInputAndOutputSignatureBlob", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DGetInputAndOutputSignatureBlob_(IntPtr pSrcData, SlimDX2.Size srcDataSize, out IntPtr signatureBlobRef);		
        
        /// <summary>	
        /// Removes blobs from a compilation result.	
        /// </summary>	
        /// <param name="pShaderBytecode">A pointer to source data as compiled HLSL code.</param>
        /// <param name="bytecodeLength">Length of pSrcData.</param>
        /// <param name="uStripFlags">Strip flag options, represented by <see cref="SlimDX2.D3DCompiler.StripFlags"/>.</param>
        /// <param name="strippedBlobRef">Optional. A pointer to an <see cref="SlimDX2.Direct3D.Blob"/> that contains compiler error messages, or NULL if there were no errors.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DStripShader([In, Buffer] LPCVOID pShaderBytecode,[In] SIZE_T BytecodeLength,[In] UINT uStripFlags,[Out] ID3DBlob** ppStrippedBlob)</unmanaged>
		public static SlimDX2.Result StripShader(IntPtr pShaderBytecode, SlimDX2.Size bytecodeLength, SlimDX2.D3DCompiler.StripFlags uStripFlags, out SlimDX2.Direct3D.Blob strippedBlobRef) {
            unsafe {
                IntPtr strippedBlobRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DStripShader_( pShaderBytecode,  bytecodeLength,  uStripFlags, out strippedBlobRef_);
                strippedBlobRef = (strippedBlobRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(strippedBlobRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DStripShader([In, Buffer] LPCVOID pShaderBytecode,[In] SIZE_T BytecodeLength,[In] UINT uStripFlags,[Out] ID3DBlob** ppStrippedBlob)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DStripShader", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DStripShader_(IntPtr pShaderBytecode, SlimDX2.Size bytecodeLength, SlimDX2.D3DCompiler.StripFlags uStripFlags, out IntPtr strippedBlobRef);		
        
        /// <summary>	
        /// Retrieves a specific part from a compilation result.	
        /// </summary>	
        /// <remarks>	
        /// D3DGetBlobPart retrieves the part of a blob (arbitrary length data buffer) that contains the type of data that the  Part parameter specifies.	
        /// </remarks>	
        /// <param name="pSrcData">A pointer to uncompiled shader data; either ASCII HLSL code or a compiled effect.</param>
        /// <param name="srcDataSize">Length of uncompiled shader data that pSrcData points to.</param>
        /// <param name="part">A <see cref="SlimDX2.D3DCompiler.BlobPart"/>-typed value that specifies the part of the buffer to retrieve.</param>
        /// <param name="flags">Flags that indicate how to retrieve the blob part. Currently, no flags are defined.</param>
        /// <param name="partRef">The address of a pointer to the <see cref="SlimDX2.Direct3D.Blob"/> interface that is used to retrieve the specified part of the buffer.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DGetBlobPart([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In] D3D_BLOB_PART Part,[In] UINT Flags,[Out] ID3DBlob** ppPart)</unmanaged>
		public static SlimDX2.Result GetBlobPart(IntPtr pSrcData, SlimDX2.Size srcDataSize, SlimDX2.D3DCompiler.BlobPart part, int flags, out SlimDX2.Direct3D.Blob partRef) {
            unsafe {
                IntPtr partRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DGetBlobPart_( pSrcData,  srcDataSize,  part,  flags, out partRef_);
                partRef = (partRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(partRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DGetBlobPart([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In] D3D_BLOB_PART Part,[In] UINT Flags,[Out] ID3DBlob** ppPart)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DGetBlobPart", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DGetBlobPart_(IntPtr pSrcData, SlimDX2.Size srcDataSize, SlimDX2.D3DCompiler.BlobPart part, int flags, out IntPtr partRef);		
        
        /// <summary>	
        /// Compresses a set of shaders into a more compact form. 	
        /// </summary>	
        /// <param name="uNumShaders">The number of shaders to compress.</param>
        /// <param name="shaderDataRef">An array of <see cref="SlimDX2.D3DCompiler.ShaderData"/> structures that describe the set of shaders to compress.</param>
        /// <param name="uFlags">Flags that indicate how to compress the shaders. Currently, only the  D3D_COMPRESS_SHADER_KEEP_ALL_PARTS (0x00000001) flag is defined.</param>
        /// <param name="compressedDataRef">The address of a pointer to the <see cref="SlimDX2.Direct3D.Blob"/> interface that is used to retrieve the compressed shader data.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DCompressShaders([In] UINT uNumShaders,[In, Buffer] D3D_SHADER_DATA* pShaderData,[In] UINT uFlags,[Out] ID3DBlob** ppCompressedData)</unmanaged>
		public static SlimDX2.Result CompressShaders(int uNumShaders, SlimDX2.D3DCompiler.ShaderData[] shaderDataRef, int uFlags, out SlimDX2.Direct3D.Blob compressedDataRef) {
            unsafe {
                IntPtr compressedDataRef_ = IntPtr.Zero;
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DCompressShaders_( uNumShaders,  shaderDataRef,  uFlags, out compressedDataRef_);
                compressedDataRef = (compressedDataRef_ == IntPtr.Zero)?null:new SlimDX2.Direct3D.Blob(compressedDataRef_);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DCompressShaders([In] UINT uNumShaders,[In, Buffer] D3D_SHADER_DATA* pShaderData,[In] UINT uFlags,[Out] ID3DBlob** ppCompressedData)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DCompressShaders", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DCompressShaders_(int uNumShaders, SlimDX2.D3DCompiler.ShaderData[] shaderDataRef, int uFlags, out IntPtr compressedDataRef);		
        
        /// <summary>	
        /// Decompresses one or more shaders from a compressed set. 	
        /// </summary>	
        /// <param name="pSrcData">A pointer to uncompiled shader data; either ASCII HLSL code or a compiled effect.</param>
        /// <param name="srcDataSize">Length of uncompiled shader data that pSrcData points to.</param>
        /// <param name="uNumShaders">The number of shaders to decompress.</param>
        /// <param name="uStartIndex">The index of the first shader to decompress.</param>
        /// <param name="indicesRef">An array of indexes that represent the shaders to decompress.</param>
        /// <param name="uFlags">Flags that indicate how to decompress. Currently, no flags are defined.</param>
        /// <param name="shadersRef">The address of a pointer to the <see cref="SlimDX2.Direct3D.Blob"/> interface that is used to retrieve the decompressed shader data.</param>
        /// <param name="totalShadersRef">A pointer to a variable that receives the total number of shaders that  D3DDecompressShaders decompressed.</param>
        /// <returns>Returns one of the following {{Direct3D 10 Return Codes}}.</returns>
        /// <unmanaged>HRESULT D3DDecompressShaders([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In] UINT uNumShaders,[In] UINT uStartIndex,[In, Buffer, Optional] UINT* pIndices,[In] UINT uFlags,[Out, Buffer] ID3DBlob** ppShaders,[Out, Optional] UINT* pTotalShaders)</unmanaged>
		public static SlimDX2.Result DecompressShaders(IntPtr pSrcData, SlimDX2.Size srcDataSize, int uNumShaders, int uStartIndex, int[] indicesRef, int uFlags, SlimDX2.Direct3D.Blob[] shadersRef, out int totalShadersRef) {
            unsafe {
                IntPtr[] shadersRef_ = new IntPtr[shadersRef.Length];
                SlimDX2.Result __result__;
                __result__= (SlimDX2.Result)D3DDecompressShaders_( pSrcData,  srcDataSize,  uNumShaders,  uStartIndex,  indicesRef,  uFlags, shadersRef_, out totalShadersRef);
              for(int i = 0; i < shadersRef.Length; i++)
                    shadersRef[i] = new SlimDX2.Direct3D.Blob(shadersRef_[i]);
                __result__.CheckError();
                return __result__;
            }
        }
		
		/// <summary>Native Interop Function</summary>
        /// <unmanaged>HRESULT D3DDecompressShaders([In, Buffer] LPCVOID pSrcData,[In] SIZE_T SrcDataSize,[In] UINT uNumShaders,[In] UINT uStartIndex,[In, Buffer, Optional] UINT* pIndices,[In] UINT uFlags,[Out, Buffer] ID3DBlob** ppShaders,[Out, Optional] UINT* pTotalShaders)</unmanaged>
		[DllImport("d3dcompiler_43.dll", EntryPoint = "D3DDecompressShaders", CallingConvention = CallingConvention.StdCall, PreserveSig = true), SuppressUnmanagedCodeSecurityAttribute]
		private extern static SlimDX2.Result D3DDecompressShaders_(IntPtr pSrcData, SlimDX2.Size srcDataSize, int uNumShaders, int uStartIndex, int[] indicesRef, int uFlags, IntPtr[] shadersRef, out int totalShadersRef);		
    }
}