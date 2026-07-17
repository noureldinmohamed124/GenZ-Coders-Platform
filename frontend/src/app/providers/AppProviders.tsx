import type { PropsWithChildren } from "react";
import { HelmetProvider } from "react-helmet-async";
import { QueryClientProvider } from "@tanstack/react-query";
import { Toaster } from "react-hot-toast";

import { queryClient } from "./queryClient";

export default function AppProviders({ children }: PropsWithChildren) {
    return (
        <HelmetProvider>
            <QueryClientProvider client={queryClient}>
                {children}

                <Toaster position="top-right" reverseOrder={false} />
            </QueryClientProvider>
        </HelmetProvider>
    );
}
