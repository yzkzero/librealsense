// License: Apache 2.0. See LICENSE file in root directory.

namespace Intel.RealSense
{
    using System;
    using System.Runtime.InteropServices;

    public class NetDevice : Device
    {
        private static IntPtr CreateNetDevice(string address)
        {
            object error;
            return NativeMethods.rs2_create_net_device(Context.ApiVersion, address, out error);
        }

        public NetDevice(string address)
            : base(CreateNetDevice(address))
        {
        }

        public void AddTo(Context ctx)
        {
            object error;
            NativeMethods.rs2_context_add_software_device(ctx.Handle, Handle, out error);
        }
    }
}
