import { createBrowserRouter, RouterProvider } from "react-router-dom";

import MainLayout from "@/app/layouts/MainLayout";

import HomePage from "@/features/landing/pages/HomePage";
import ProgramsPage from "@/features/programs/pages/ProgramsPage";
import RegistrationPage from "@/features/registration/pages/RegistrationPage";
import ConsultationPage from "@/features/consultation/pages/ConsultationPage";

const router = createBrowserRouter([
    {
        path: "/",
        element: <MainLayout />,
        children: [
            {
                index: true,
                element: <HomePage />,
            },
            {
                path: "programs",
                element: <ProgramsPage />,
            },
            {
                path: "registration",
                element: <RegistrationPage />,
            },
            {
                path: "consultation",
                element: <ConsultationPage />,
            },
        ],
    },
]);

export default function AppRouter() {
    return <RouterProvider router={router} />;
}
